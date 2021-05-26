using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Helper;

namespace SimpleAPITestTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string sDestinationUrl = string.Empty;
        private string strJsonInput = string.Empty;
        private string strMethod = string.Empty;
        private const string Authorization_Key = "Authorization";
        private void frmMain_Load(object sender, EventArgs e)
        {
            btnSend.MinimumSize = new System.Drawing.Size(30, 25);
            cbxAuthType.SelectedIndex = 0;
            tbMain.SelectedTab = tbHeader;
        }

        private bool FormValidate()
        {
            bool Result = true;
            if (cbxMethod.SelectedIndex < 0)
            {
                Result = false;
                MessageBox.Show("Method cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxMethod.Focus();
            }
            else if (string.IsNullOrEmpty(txtDestination.Text))
            {
                Result = false;
                MessageBox.Show("Destination URL cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDestination.Focus();
            }
            else if (string.IsNullOrEmpty(txtPayload.Text) && cbxMethod.SelectedItem.ToString() == "POST")
            {
                Result = false;
                MessageBox.Show("Payload cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMain.SelectedTab = tbPayload;
                txtDestination.Focus();
            }
            return Result;
        }

        private Dictionary<string, string> GetHeaders()
        {
            Dictionary<string, string> objHttpHeaders = new Dictionary<string, string>();
            foreach (DataGridViewRow Row in gvHeaders.Rows)
            {
                if (Convert.ToBoolean(Row.Cells["hdrChk"].Value))
                {
                    objHttpHeaders.Add(Row.Cells["hdrKey"].Value.ToString().Trim(), Row.Cells["hdrValue"].Value.ToString().Trim());
                }
            }
            return objHttpHeaders;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if(FormValidate())
                {                    
                    sDestinationUrl = txtDestination.Text.Trim();
                    strJsonInput = txtPayload.Text;
                    txtResult.Text = "Processing...";
                    btnSend.Enabled = false;
                    strMethod = cbxMethod.SelectedItem.ToString();
                    Dictionary<string, string> objHeaders = GetHeaders();

                    Task<string> task = Task<string>.Factory.StartNew(() => strMethod == "POST" ? DoHttpPost(sDestinationUrl, objHeaders, strJsonInput) : DoHttpGet(sDestinationUrl, objHeaders));
                    task.ContinueWith(t => {
                        string sReponse = string.Format("{1}{0}{1}", t.Result, Environment.NewLine);
                        string sResponseFormatted = sReponse.ToJson();// Utils.FormatJson(sReponse);
                        txtResult.Invoke((MethodInvoker)(() => txtResult.Text = sResponseFormatted)) ;
                        btnSend.Invoke((MethodInvoker)(() => btnSend.Enabled = true));                        
                    });
                    tbMain.SelectedTab = tbResult;
                }
            }
            catch(Exception Err)
            {
                txtResult.Text += Err.Message;
            }
            finally
            {
                
            }
        }

        private void EnableButton(bool btnVisible)
        {
            btnSend.Enabled = btnVisible;
        }

        private string DoHttpPost(string sUrl, Dictionary<string, string> objHeaders, string sPayload)
        {
            try
            {
                string sReponse;
                HTTPHelper.HttpWebResponsePOST(null, sUrl, objHeaders, sPayload, HTTPHelper.HTTPContentType.JSON,out sReponse);
                return sReponse;
            }
            catch(Exception Err)
            {
                throw Err;
            }
        }

        private string DoHttpGet(string sUrl, Dictionary<string, string> objHeaders)
        {
            try
            {
                string sReponse;
                HTTPHelper.HttpWebResponseGET(null, sUrl, objHeaders, out sReponse);
                return sReponse;
            }
            catch (Exception Err)
            {
                throw Err;
            }
        }
       
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPasswod.Checked ? '\0' : '*';
        }

        private bool SaveAuthValidation()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                txtPassword.Focus();
            }

            if(result)
            {
                foreach (DataGridViewRow Row in gvHeaders.Rows)
                {
                    if (Row.Cells["hdrKey"].Value != null)
                    {
                        if (Row.Cells["hdrKey"].Value.ToString().Trim().ToLower() == Authorization_Key.ToLower())
                        {
                            MessageBox.Show("Custom authorization header already been added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            result = false;
                            tbMain.SelectedTab = tbHeader;
                        }
                    }
                }
            }

            return result;
        }
        private void btnSaveAuthType_Click(object sender, EventArgs e)
        {
            if(SaveAuthValidation())
            {
                string Username = txtUsername.Text.Trim();
                string Password = txtPassword.Text.Trim();
                gvHeaders.Rows.Add(true, Authorization_Key, HTTPHelper.GetBasicAuthHeaderKey(Username, Password));
                tbMain.SelectedTab = tbHeader;
            }           
        }
    }
}
