using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using System.Diagnostics;
using VisualAsterisk.Core;
using System.Xml.Serialization;

namespace VisualAsterisk.Main.Gui
{
    public partial class CheckUpdatesDlg : DialogBase
    {
        private const string versionFileSavedPath = @"setup\version.xml";
        private const string installFileSavedPath = @"setup\VisualAsterisk.msi";
        private int installFileLength;
        private WebResponse httpResponse;
        private WebClient webClient = new WebClient();

        delegate void UIUpdateDelegate(string bytes);
        private UIUpdateDelegate uiUpdateDelegate;

        void updateUI(string value)
        {
            //this.label1.Text = value;
            //this.progressBar1.Value = Int32.Parse(value);
            this.downloadingLabel.Text = value;
            if (value == "Download completed")
            {
                changeFont(this.downloadingLabel, true);
                installUpdatesButton.Enabled = true;
                changeFont(this.readyLabel, false);
            }
            else if (value == "")
            {
                changeFont(this.downloadingLabel, true);
            }
        }

        public CheckUpdatesDlg()
        {
            InitializeComponent();
            uiUpdateDelegate = new UIUpdateDelegate(updateUI);
            Directory.CreateDirectory("setup");
        }

        private VisualAsteriskVersion getLatestVersion()
        {
            checkForUpdatesButton.Enabled = false;
            Cursor old = this.Cursor;
            this.Cursor = Cursors.WaitCursor; 
            string versionFileURL = Properties.Settings.Default.UpdatesURL + "/version.xml";
            
            Uri uri = new Uri(versionFileURL);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);

            request.Credentials = new NetworkCredential("visualasterisk@telnv.com", "C*qIxk1wHF$u");
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream fs = response.GetResponseStream();

            VisualAsteriskVersion latestVersion = null;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(VisualAsteriskVersion));
                latestVersion = xs.Deserialize(fs) as VisualAsteriskVersion;
                fs.Close();
            }
            catch (IOException)
            {
                throw;
            }
            this.Cursor = old; 

            return latestVersion;
        }

        private void changeFont(Control control, bool toDefault)
        {
            if (toDefault)
            {
                control.Font = Control.DefaultFont;
                control.ForeColor = Control.DefaultForeColor;
                control.Enabled = false;
            }
            else
            {
                control.Font = new Font(Control.DefaultFont.FontFamily, Control.DefaultFont.Size, FontStyle.Bold);
                control.ForeColor = System.Drawing.Color.Red;
                control.Enabled = true;
            }
        }

        private void checkForUpdatesButton_Click(object sender, EventArgs e)
        {
            try
            {
                changeFont(this.checkingLabel, false);
                VisualAsteriskVersion thisVersion = new VisualAsteriskVersion(typeof(AsteriskAdminUI).Assembly.GetName().Version.ToString(4));
                VisualAsteriskVersion latestVersion = getLatestVersion();
                changeFont(this.checkingLabel, true);

                if (latestVersion != null && latestVersion.NewerThan(thisVersion))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("The latest version is " + latestVersion.Version);
                    sb.AppendLine("");
                    sb.AppendLine("New features:");
                    foreach (string item in latestVersion.Features)
                    {
                        sb.AppendLine(item);
                    }
                    sb.AppendLine();
                    sb.AppendLine("Bugfixes:");
                    foreach (string item in latestVersion.Bugfixes)
                    {
                        sb.AppendLine(item);
                    }
                    sb.AppendLine().AppendLine();
                    sb.AppendLine("Do you want donwload this version for update?");

                    string info = string.Format("The latest version is {0}\r\n\r\n Features:", latestVersion.Version);
                    if (MessageBox.Show(sb.ToString(),"New version found!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        changeFont(this.downloadingLabel, false);
                        downloadInstallFile();
                    }
                }
                else
                {
                    MessageBox.Show("You have the lastest version of VisualAsterisk installed, there's no update yet");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Check for update failed: {0}", ex.Message));
            }
        }

        private void downloadInstallFile()
        {
            string installFileURL = Properties.Settings.Default.UpdatesURL + "/VisualAsterisk.msi";

            //webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClient_DownloadProgressChanged);
            //webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted);
            //webClient.DownloadFileAsync(new Uri(installFileURL), installFileSavedPath);

            try
            {
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(installFileURL);
                ftp.UsePassive = true;
                ftp.Credentials = new NetworkCredential("visualasterisk@telnv.com", "C*qIxk1wHF$u");
                FtpWebResponse resp = (FtpWebResponse)ftp.GetResponse();
                Stream ms = resp.GetResponseStream();


                FileStream fs = new FileStream(installFileSavedPath, FileMode.Create);
                int b;
                while ((b = ms.ReadByte()) != -1)
                {
                    fs.WriteByte((byte)b);
                }
                fs.Close();
                ms.Close();
                string status = "Download completed";
                this.Invoke(uiUpdateDelegate, status);
            }
            catch (WebException we)
            {
                MessageBox.Show(string.Format("File donwload failed, {0} {1}", 
                    ((FtpWebResponse)we.Response).StatusCode, ((FtpWebResponse)we.Response).StatusDescription));
                this.Close();
            } 
        }

        void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string status = e.Cancelled ? "Download canceled" : "Download completed";
            this.Invoke(uiUpdateDelegate, status);
        }

        void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            string status = string.Format("Downloading file, progress {0}/{1} bytes",
                e.BytesReceived, e.TotalBytesToReceive);
            this.Invoke(uiUpdateDelegate, status);
        }


        private void installUpdatesButton_Click(object sender, EventArgs e)
        {
            installUpdatesButton.Enabled = false;
            Process process = new Process();
            process.StartInfo.FileName = installFileSavedPath;
            process.Start();
            this.Close();
        }
    }
}
