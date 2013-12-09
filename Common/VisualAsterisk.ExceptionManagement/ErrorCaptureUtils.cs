using System;
using System.Collections.Generic;
using System.Text;
using IC.Utilities;
using System.Net;
using System.IO;
using System.Xml.Serialization;

namespace VisualAsterisk.ExceptionManagement
{
    public class ExceptionEventArgs : EventArgs
    {
        public Exception Exception;

        public ExceptionEventArgs(Exception exception)
        {
            this.Exception = exception;
        }
    }

    public class ErrorCaptureUtils
    {
        public static event EventHandler<ExceptionEventArgs> OnSendError;

        public static void SendError(Exception ex, string licenseKey, string licenseName, string version,  string url)
        {
            SendError(ex, licenseKey, licenseName, version, url, false);
        }

        public static void SendError(Exception ex, string licenseKey, string licenseName, string version, string url, bool showDialog)
        {
            try
            {
                if (OnSendError != null)
                {
                    OnSendError(null, new ExceptionEventArgs(ex));
                }

                ErrorPacket ePack = GetErrorPacket(ex, licenseKey, licenseName, version);

                if (showDialog)
                {
                    Dialogs.ErrorCaptureDialog dlg = new Dialogs.ErrorCaptureDialog(ePack);
                    if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                    {
                        // save 
                        Directory.CreateDirectory("ErrorReports");
                        string fileName = "ErrorReport_" + Guid.NewGuid().ToString() + ".xml";
                        saveErrorPacket(ePack, "ErrorReports\\" + fileName);
                        // upload
                        WebClient webClient = new WebClient();
                        webClient.Credentials = new NetworkCredential("visualasterisk@telnv.com", "C*qIxk1wHF$u");
                        webClient.UploadFile(new Uri(url + "/" + fileName), "ErrorReports\\" + fileName);
                        //svc.HandleWOSIException(BuildProxy(ePack));
                    }
                }
                else
                {
                    //svc.HandleWOSIException(BuildProxy(ePack));
                }
            }
            catch
            {
            }
        }

        private static void saveErrorPacket(ErrorPacket errorPacket, string fileName)
        {                   
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
                XmlSerializer xs = new XmlSerializer(typeof(ErrorPacket));
                xs.Serialize(fs, errorPacket);
                fs.Close();
            }
            catch (IOException)
            {
                throw;
            }
        }

        private static ErrorPacket loadErrorPacket(string fileName)
        {
            ErrorPacket packet;
            FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(ErrorPacket));
            packet = (ErrorPacket)xs.Deserialize(fs);
            fs.Close();
            return packet;
        }

        private static ErrorPacket GetErrorPacket(Exception ex, string licenseKey, string licenseName, string version)
        {
            ErrorPacket ePack = new ErrorPacket();

            try
            {
                ePack.ApplicationName = System.Windows.Forms.Application.ProductName;
            }
            catch
            {
            }

            ePack.Culture = System.Globalization.CultureInfo.CurrentCulture.EnglishName;
            ePack.ClientIpAddress = NetworkUtils.GetCurrentIpAddress();
            ePack.ExceptionMessage = ex.Message;
            ePack.StackTrace = ex.StackTrace;
            if (ex.InnerException != null)
            {
                ePack.StackTrace += "\r\n*****Inner Exception****\r\n";
                ePack.StackTrace += ex.InnerException.ToString();
            }
            ePack.ExceptionType = ex.GetType().ToString();
            ePack.LicenseKey = licenseKey;
            ePack.LicenseName = licenseName;
            ePack.OSVersion = System.Environment.OSVersion.ToString();
            ePack.Timestamp = System.DateTime.Now;
            ePack.Version = version;
                
            return ePack;
        }
    }

    [Serializable]
    public struct ErrorPacket
    {
        [ShowOnErrorAttribute("Time")]
        public DateTime Timestamp;
        [ShowOnErrorAttribute("Application")]
        public string ApplicationName;
        [ShowOnErrorAttribute("Error")]
        public string ExceptionMessage;
        [ShowOnErrorAttribute("IP Address")]
        public string ClientIpAddress;
        [ShowOnErrorAttribute("License Name")]
        public string LicenseName;
        [ShowOnErrorAttribute("License Key")]
        public string LicenseKey;
        public string Culture;
        [ShowOnErrorAttribute("OS Version")]
        public string OSVersion;
        public string ExceptionType;
        [ShowOnErrorAttribute("Stack Trace")]
        public string StackTrace;
        public string Version;
    }

    public class ShowOnErrorAttribute : System.Attribute
    {
        private string _friendlyName;
        
        public ShowOnErrorAttribute(string friendlyName)
        {
            FriendlyName = friendlyName;
        }

        public string FriendlyName
        {
            get
            {
                return _friendlyName;
            }
            private set
            {
                _friendlyName = value;
            }
        }
    }

}
