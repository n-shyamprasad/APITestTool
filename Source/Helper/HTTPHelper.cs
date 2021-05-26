using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace Helper
{
    public class HTTPHelper
    {
        public enum HTTPContentType { UTF8, JSON };

        public static bool HttpWebResponseGET(WebProxy objProxy, string strURL, out string strResponse)
        {
            try
            {
                WebRequest webRequest = (WebRequest) WebRequest.Create(strURL);
                webRequest.Method = "GET";
                if (objProxy != null)
                    webRequest.Proxy = objProxy;

                using(WebResponse webResponse = webRequest.GetResponse())
                {
                    using (Stream objData = webResponse.GetResponseStream())
                    using (var objReader = new StreamReader(objData))
                        strResponse = objReader.ReadToEnd();
                }
                return true;
            }
            catch(WebException ex)
            {
                using (WebResponse webResponse = ex.Response)
                {
                    HttpWebResponse httpWebResponse = (HttpWebResponse)webResponse;
                    Console.WriteLine("Error Code: {0} for {1}", httpWebResponse.StatusCode, strURL);
                    using (Stream objData = webResponse.GetResponseStream())
                    using (var objReader = new StreamReader(objData))
                        strResponse = objReader.ReadToEnd();
                }
                return false;
            }
        }

        public static bool HttpWebResponseGET(WebProxy objProxy, string strURL, Dictionary<string, string> objHttpHeader, out string strResponse)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, charin, sslPolicyErrors) => true;
            try
            {
                WebRequest webRequest = (WebRequest)WebRequest.Create(strURL);
                webRequest.Method = "GET";
                if (objHttpHeader != null)
                    foreach (KeyValuePair<string, string> item in objHttpHeader)
                        webRequest.Headers.Add(item.Key, item.Value);
                if (objProxy != null)
                    webRequest.Proxy = objProxy;          

                using (WebResponse webResponse = webRequest.GetResponse())
                {
                    using (Stream objData = webResponse.GetResponseStream())
                    using (var objReader = new StreamReader(objData))
                        strResponse = objReader.ReadToEnd();
                }
                return true;
            }
            catch (WebException ex)
            {
                using (WebResponse webResponse = ex.Response)
                {
                    HttpWebResponse httpWebResponse = (HttpWebResponse)webResponse;
                    Console.WriteLine("Error Code: {0} for {1}", httpWebResponse.StatusCode, strURL);
                    using (Stream objData = webResponse.GetResponseStream())
                    using (var objReader = new StreamReader(objData))
                        strResponse = objReader.ReadToEnd();
                }
                return false;
            }
        }

        public static bool HttpWebResponseGET(WebProxy objProxy, string strURL, Dictionary<string, string> objHttpHeader, out string strResponse, CredentialCache credentialCache)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, charin, sslPolicyErrors) => true;
            try
            {
                WebRequest webRequest = (WebRequest)WebRequest.Create(strURL);
                webRequest.Method = "GET";
                if (objHttpHeader != null)
                    foreach (KeyValuePair<string, string> item in objHttpHeader)
                        webRequest.Headers.Add(item.Key, item.Value);
                if (objProxy != null)
                    webRequest.Proxy = objProxy;

                if (credentialCache != null)
                {
                    webRequest.PreAuthenticate = true;
                    webRequest.Credentials = credentialCache;
                }               

                using (WebResponse webResponse = webRequest.GetResponse())
                {
                    using (Stream objData = webResponse.GetResponseStream())
                    using (var objReader = new StreamReader(objData))
                        strResponse = objReader.ReadToEnd();
                }
                return true;
            }
            catch (WebException ex)
            {
                using (WebResponse webResponse = ex.Response)
                {
                    HttpWebResponse httpWebResponse = (HttpWebResponse)webResponse;
                    Console.WriteLine("Error Code: {0} for {1}", httpWebResponse.StatusCode, strURL);
                    using (Stream objData = webResponse.GetResponseStream())
                    using (var objReader = new StreamReader(objData))
                        strResponse = objReader.ReadToEnd();
                }
                return false;
            }
        }

        public static bool HttpWebResponsePOST(WebProxy objProxy, string strURL, Dictionary<string, string> objHttpHeader, string strPostData, HTTPContentType enumContentType, out string strContent)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, charin, sslPolicyErrors) => true;
            try
            {
                WebRequest webRequest = (WebRequest)WebRequest.Create(strURL);
                Encoding objEncoding = new UTF8Encoding();
                byte[] objData = objEncoding.GetBytes(strPostData);
                webRequest.Method = "GET";
                if (objHttpHeader != null)
                    foreach (KeyValuePair<string, string> item in objHttpHeader)
                        webRequest.Headers.Add(item.Key, item.Value);
                webRequest.ContentLength = objData.Length;
                if(enumContentType == HTTPContentType.UTF8)
                    webRequest.ContentType = "charset=UTF-8";
                else
                    webRequest.ContentType = "application/json";

                if (objProxy != null)
                    webRequest.Proxy = objProxy;

                Stream objStream = webRequest.GetRequestStream();
                objStream.Write(objData, 0, objData.Length);
                objStream.Close();

                using (HttpWebResponse webResponse = (HttpWebResponse) webRequest.GetResponse())
                {
                    using (Stream data = webResponse.GetResponseStream())
                    using (var objReader = new StreamReader(data))
                        strContent = objReader.ReadToEnd();
                }
                return true;
            }
            catch (WebException ex)
            {
                if (ex.Response == null)
                    strContent = ex.Message;
                else
                {
                    using (WebResponse webResponse = ex.Response)
                    {
                        HttpWebResponse httpWebResponse = (HttpWebResponse)webResponse;
                        Console.WriteLine("Error Code: {0} for {1}", httpWebResponse.StatusCode, strURL);
                        using (Stream objData = webResponse.GetResponseStream())
                        using (var objReader = new StreamReader(objData))
                            strContent = objReader.ReadToEnd();
                    }
                }
                return false;
            }
        }

        public static string GetBasicAuthHeaderKey(string username, string password)
        {
            string authInfo = username + ":" + password;
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            return "Basic " + authInfo;
        }
        public static CredentialCache GetCredentialCache(string Url, string Username, string Password)
        {
            NetworkCredential myNetworkCredential = new NetworkCredential(Username, Password);
            CredentialCache myCredentialCache = new CredentialCache();
            myCredentialCache.Add(new Uri(Url), AuthenticationSchemes.Basic.ToString(), myNetworkCredential);
            return myCredentialCache;
        }
    }
}
