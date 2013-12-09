using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using VisualAsterisk.ExceptionManagement;
using VisualAsterisk.ExceptionManagement.Dialogs;

namespace ReportedBugManager
{
    public partial class BugManager : Form
    {
        private List<Bug> bugs = new List<Bug>();

        public BugManager()
        {
            InitializeComponent();
            this.bugStatusComboBox.Items.Add(BugState.NewFound);
            this.bugStatusComboBox.Items.Add(BugState.Fixed);

            loadBugs();
            foreach (Bug bug in bugs)
            {
                ListViewItem item = new ListViewItem(new string[] { bug.ErrorPacketFileName,bug.ErrorPacket.ApplicationName,
                    bug.OcurrTime.ToShortDateString(), bug.Version, bug.State.ToString() } );
                item.Tag = bug;
                this.listView1.Items.Add(item);
            }
        }

        private void loadBugs()
        {
            bugs.Clear();
            try
            {
                FileStream fs = new FileStream("bugs.xml", FileMode.Open);
                XmlSerializer xs = new XmlSerializer(typeof(List<Bug>));                
                bugs = xs.Deserialize(fs) as List<Bug>;
                fs.Close();
            }
            catch (FileNotFoundException e)
            {
                Trace.TraceWarning("File not found: {0}", e.Message);
            }
            catch (IOException)
            {
                throw;
            }
        }

        private void saveBugs()
        {
            try
            {
                FileStream fs = new FileStream("bugs.xml", FileMode.OpenOrCreate);
                XmlSerializer xs = new XmlSerializer(typeof(List<Bug>));
                xs.Serialize(fs, bugs);
                fs.Close();
            }
            catch (IOException)
            {
                throw;
            }
        }

        private void synchronizeButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Stream inStream = null;
            Stream outStream = null;
            Cursor currentCursor = this.Cursor;
            FtpWebResponse response = null;
            Stream stream = null;
            string ftpDirectory = "visualasterisk/bugreports";

            try
            {
                string server = Properties.Settings.Default.BaseURL;
                string username = Properties.Settings.Default.User;
                string password = Properties.Settings.Default.Password;
                FtpWebRequest request =
                        (FtpWebRequest)WebRequest.Create(server + "/" + ftpDirectory);
                request.Credentials = new NetworkCredential(username, password);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                response = (FtpWebResponse)request.GetResponse();
                stream = response.GetResponseStream();

                // get file list   
                StreamReader reader = new StreamReader(stream);
                string content = reader.ReadToEnd();
                string[] files = content.Split('\n');
                reader.Close();

                // download files
                Uri baseUri = new Uri(server);

                for (int i = 0; i < files.Length; i++)
                {
                    string filename = files[i].Trim('\r');
                    if (string.IsNullOrEmpty(filename) || filename == "." || filename == "..")
                    {
                        continue;
                    }

                    bool oldFile = false;
                    foreach (Bug bug in bugs)
                    {
                        if (bug.ErrorPacketFileName == filename)
                        {
                            oldFile = true;
                            break;
                        }
                    }

                    if (oldFile)
                    {
                        continue;
                    }

                    string fullFilename = ftpDirectory + @"/" + filename;

                    Uri uri = new Uri(baseUri, fullFilename);

                    request = (FtpWebRequest)WebRequest.Create(uri);

                    request.Credentials = new NetworkCredential(username, password);
                    request.Method = WebRequestMethods.Ftp.DownloadFile;


                    response = (FtpWebResponse)request.GetResponse();
                    inStream = response.GetResponseStream();

                    ErrorPacket pack;
                    XmlSerializer xs = new XmlSerializer(typeof(ErrorPacket));
                    pack = (ErrorPacket)xs.Deserialize(inStream);
                    AddNewBug(filename, pack);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error   FTP   client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (response != null)
                    response.Close();
                if (stream != null)
                    stream.Close();
                this.Cursor = Cursors.Default;
            }
        }

        private void AddNewBug(string filename, ErrorPacket pack)
        {
            Bug bug = new Bug();
            bug.ErrorPacketFileName = filename;
            bug.ErrorPacket = pack;
            bug.State = BugState.NewFound;
            bugs.Add(bug);
            ListViewItem item = new ListViewItem(new string[] { bug.ErrorPacketFileName,bug.ErrorPacket.ApplicationName,
                    bug.OcurrTime.ToShortDateString(), bug.Version, bug.State.ToString() });
            item.Tag = bug;
            this.listView1.Items.Add(item);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Bug bug = listView1.SelectedItems[0].Tag as Bug;
                ShowErrorDialog dlg = new ShowErrorDialog(bug.ErrorPacket);
                dlg.ShowDialog();
            }
        }

        private void BugManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveBugs();
        }

        private void bugStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Bug bug = listView1.SelectedItems[0].Tag as Bug;
                bug.State = (BugState) bugStatusComboBox.SelectedItem;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Bug bug = listView1.SelectedItems[0].Tag as Bug;
                bugStatusComboBox.SelectedItem = bug.State;
            }
        }
    }
}
