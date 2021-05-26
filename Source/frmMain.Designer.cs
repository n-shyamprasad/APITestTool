
namespace SimpleAPITestTool
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tbAuth = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveAuthType = new System.Windows.Forms.Button();
            this.chkShowPasswod = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAuthType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHeader = new System.Windows.Forms.TabPage();
            this.gvHeaders = new System.Windows.Forms.DataGridView();
            this.hdrChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hdrkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdrValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPayload = new System.Windows.Forms.TabPage();
            this.txtPayload = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.cbxMethod = new System.Windows.Forms.ComboBox();
            this.tbMain.SuspendLayout();
            this.tbAuth.SuspendLayout();
            this.tbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHeaders)).BeginInit();
            this.tbPayload.SuspendLayout();
            this.tbResult.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tbAuth);
            this.tbMain.Controls.Add(this.tbHeader);
            this.tbMain.Controls.Add(this.tbPayload);
            this.tbMain.Controls.Add(this.tbResult);
            this.tbMain.Location = new System.Drawing.Point(5, 41);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(884, 488);
            this.tbMain.TabIndex = 3;
            // 
            // tbAuth
            // 
            this.tbAuth.Controls.Add(this.label4);
            this.tbAuth.Controls.Add(this.btnSaveAuthType);
            this.tbAuth.Controls.Add(this.chkShowPasswod);
            this.tbAuth.Controls.Add(this.txtPassword);
            this.tbAuth.Controls.Add(this.label3);
            this.tbAuth.Controls.Add(this.txtUsername);
            this.tbAuth.Controls.Add(this.label2);
            this.tbAuth.Controls.Add(this.cbxAuthType);
            this.tbAuth.Controls.Add(this.label1);
            this.tbAuth.Location = new System.Drawing.Point(4, 24);
            this.tbAuth.Name = "tbAuth";
            this.tbAuth.Padding = new System.Windows.Forms.Padding(3);
            this.tbAuth.Size = new System.Drawing.Size(876, 460);
            this.tbAuth.TabIndex = 3;
            this.tbAuth.Text = "Authorization";
            this.tbAuth.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "* Authorization header will be created and added to Headers as custom header.";
            // 
            // btnSaveAuthType
            // 
            this.btnSaveAuthType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAuthType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveAuthType.Location = new System.Drawing.Point(141, 182);
            this.btnSaveAuthType.Name = "btnSaveAuthType";
            this.btnSaveAuthType.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAuthType.TabIndex = 7;
            this.btnSaveAuthType.Text = "Save";
            this.btnSaveAuthType.UseVisualStyleBackColor = true;
            this.btnSaveAuthType.Click += new System.EventHandler(this.btnSaveAuthType_Click);
            // 
            // chkShowPasswod
            // 
            this.chkShowPasswod.AutoSize = true;
            this.chkShowPasswod.Location = new System.Drawing.Point(141, 146);
            this.chkShowPasswod.Name = "chkShowPasswod";
            this.chkShowPasswod.Size = new System.Drawing.Size(108, 19);
            this.chkShowPasswod.TabIndex = 6;
            this.chkShowPasswod.Text = "Show Password";
            this.chkShowPasswod.UseVisualStyleBackColor = true;
            this.chkShowPasswod.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(141, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(210, 23);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(141, 78);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(210, 23);
            this.txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // cbxAuthType
            // 
            this.cbxAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAuthType.FormattingEnabled = true;
            this.cbxAuthType.Items.AddRange(new object[] {
            "Basic Auth"});
            this.cbxAuthType.Location = new System.Drawing.Point(141, 39);
            this.cbxAuthType.Name = "cbxAuthType";
            this.cbxAuthType.Size = new System.Drawing.Size(121, 23);
            this.cbxAuthType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentication Type";
            // 
            // tbHeader
            // 
            this.tbHeader.Controls.Add(this.gvHeaders);
            this.tbHeader.Location = new System.Drawing.Point(4, 24);
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.Padding = new System.Windows.Forms.Padding(3);
            this.tbHeader.Size = new System.Drawing.Size(876, 460);
            this.tbHeader.TabIndex = 0;
            this.tbHeader.Text = "Headers";
            this.tbHeader.UseVisualStyleBackColor = true;
            // 
            // gvHeaders
            // 
            this.gvHeaders.AllowUserToResizeColumns = false;
            this.gvHeaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHeaders.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.gvHeaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvHeaders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hdrChk,
            this.hdrkey,
            this.hdrValue});
            this.gvHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvHeaders.Location = new System.Drawing.Point(3, 3);
            this.gvHeaders.Name = "gvHeaders";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gvHeaders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvHeaders.RowHeadersWidth = 40;
            this.gvHeaders.RowTemplate.Height = 25;
            this.gvHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvHeaders.Size = new System.Drawing.Size(870, 454);
            this.gvHeaders.TabIndex = 0;
            // 
            // hdrChk
            // 
            this.hdrChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hdrChk.FillWeight = 10F;
            this.hdrChk.HeaderText = "";
            this.hdrChk.Name = "hdrChk";
            this.hdrChk.Width = 55;
            // 
            // hdrkey
            // 
            this.hdrkey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hdrkey.FillWeight = 30F;
            this.hdrkey.HeaderText = "KEY";
            this.hdrkey.Name = "hdrkey";
            // 
            // hdrValue
            // 
            this.hdrValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hdrValue.HeaderText = "VALUE";
            this.hdrValue.Name = "hdrValue";
            // 
            // tbPayload
            // 
            this.tbPayload.Controls.Add(this.txtPayload);
            this.tbPayload.Location = new System.Drawing.Point(4, 24);
            this.tbPayload.Name = "tbPayload";
            this.tbPayload.Padding = new System.Windows.Forms.Padding(3);
            this.tbPayload.Size = new System.Drawing.Size(876, 460);
            this.tbPayload.TabIndex = 1;
            this.tbPayload.Text = "Payload";
            this.tbPayload.UseVisualStyleBackColor = true;
            // 
            // txtPayload
            // 
            this.txtPayload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPayload.Location = new System.Drawing.Point(3, 3);
            this.txtPayload.Multiline = true;
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPayload.Size = new System.Drawing.Size(870, 454);
            this.txtPayload.TabIndex = 0;
            // 
            // tbResult
            // 
            this.tbResult.Controls.Add(this.txtResult);
            this.tbResult.Location = new System.Drawing.Point(4, 24);
            this.tbResult.Name = "tbResult";
            this.tbResult.Padding = new System.Windows.Forms.Padding(3);
            this.tbResult.Size = new System.Drawing.Size(876, 460);
            this.tbResult.TabIndex = 2;
            this.tbResult.Text = "Result";
            this.tbResult.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(870, 454);
            this.txtResult.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtDestination);
            this.panel1.Controls.Add(this.cbxMethod);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 39);
            this.panel1.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(835, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(45, 27);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(64, 8);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(771, 23);
            this.txtDestination.TabIndex = 4;
            // 
            // cbxMethod
            // 
            this.cbxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMethod.FormattingEnabled = true;
            this.cbxMethod.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.cbxMethod.Location = new System.Drawing.Point(1, 8);
            this.cbxMethod.Name = "cbxMethod";
            this.cbxMethod.Size = new System.Drawing.Size(63, 23);
            this.cbxMethod.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbMain);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Simple API Test Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbMain.ResumeLayout(false);
            this.tbAuth.ResumeLayout(false);
            this.tbAuth.PerformLayout();
            this.tbHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHeaders)).EndInit();
            this.tbPayload.ResumeLayout(false);
            this.tbPayload.PerformLayout();
            this.tbResult.ResumeLayout(false);
            this.tbResult.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tbHeader;
        private System.Windows.Forms.DataGridView gvHeaders;
        private System.Windows.Forms.TabPage tbPayload;
        private System.Windows.Forms.TabPage tbResult;
        private System.Windows.Forms.TextBox txtPayload;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TabPage tbAuth;
        private System.Windows.Forms.ComboBox cbxAuthType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkShowPasswod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveAuthType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hdrChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdrValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.ComboBox cbxMethod;
    }
}

