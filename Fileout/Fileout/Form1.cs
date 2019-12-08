using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace jp.mn.jp.uk.fileout
{
    public partial class Form1 : Form
    {
        private string getPath = string.Empty;
        private string setPath = string.Empty;
        public Form1()
        {
            InitializeComponent();

            string c1 = System.Environment.CurrentDirectory;
            string c2 = System.IO.Directory.GetCurrentDirectory();
            string c3 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string c4 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            System.Environment.CurrentDirectory = c4;
            System.IO.Directory.SetCurrentDirectory(c4);
            getPath = c4;
            setPath = c3;
            this.txtTarget.Text = getPath;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdg = new FolderBrowserDialog();

            string path = string.Empty;

            fdg.Description = "Select folder!";
            fdg.SelectedPath = getPath;
            fdg.ShowNewFolderButton = true;

            if (fdg.ShowDialog(this) == DialogResult.OK)
            {
                getPath = fdg.SelectedPath;
                txtTarget.Text = getPath;
                DateTime now1 = DateTime.Now;
                this.txtDest.Text = System.IO.Path.Combine(setPath, now1.Year.ToString()
                    + (now1.Month < 10 ? "0" : "") + (now1.Month.ToString())
                    + (now1.Day < 10 ? "0" : "") + (now1.Day.ToString())
                    + (now1.Hour < 10 ? "0" : "") + (now1.Hour.ToString())
                    + (now1.Minute < 10 ? "0" : "") + (now1.Minute.ToString())
                    + (now1.Second < 10 ? "0" : "") + (now1.Second.ToString())
                    + ".csv");
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtTarget.Text) || !System.IO.Directory.Exists(this.txtTarget.Text))
            {
                MessageBox.Show("Not find the folder at '" + this.txtTarget.Text + "'", "Error");
                return;
            }
            if (string.IsNullOrEmpty(this.txtDest.Text) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(this.txtDest.Text)))
            {
                MessageBox.Show("Not find the folder at '" + this.txtDest.Text + "'", "Error");
                return;
            }
            if (string.IsNullOrEmpty(this.txtDest.Text) || System.IO.File.Exists(this.txtDest.Text))
            {
                if (MessageBox.Show("Are you the File overwrite OK? '" + this.txtDest.Text + "'", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                {
                    return;
                }
            }
            try
            {
                using (System.IO.StreamWriter wr = new System.IO.StreamWriter(this.txtDest.Text, false))
                {
                    wr.WriteLine("Path,FileName,update");
                    SetFileList(this.txtTarget.Text, wr);

                    MessageBox.Show("File list completed!", "Info");
                }
            }
            catch
            {
                MessageBox.Show("File list about!", "Error");
            }
        }

        private string SetFileList(string path1, System.IO.StreamWriter sw)
        {
            try
            {
                if (System.IO.Directory.Exists(path1))
                {
                    string[] subdir = System.IO.Directory.GetDirectories(path1);
                    if (subdir != null)
                    {
                        for (int i = 0; i < subdir.Length; i++)
                        {
                            System.IO.FileAttributes fas = System.IO.File.GetAttributes(subdir[i]);
                            bool bSystem =
                              ((fas & System.IO.FileAttributes.System) == System.IO.FileAttributes.System) ||
                              ((fas & System.IO.FileAttributes.Hidden) == System.IO.FileAttributes.Hidden);
                            if (bSystem == false)
                            {
                                SetFileList(subdir[i], sw);
                            }
                        }
                    }
                    string[] files = System.IO.Directory.GetFiles(path1);
                    if (files != null)
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            System.IO.FileAttributes fas = System.IO.File.GetAttributes(files[i]);
                            bool bSystem =
                              ((fas & System.IO.FileAttributes.System) == System.IO.FileAttributes.System) ||
                              ((fas & System.IO.FileAttributes.Hidden) == System.IO.FileAttributes.Hidden);
                            if (bSystem == false)
                            {
                                DateTime update = System.IO.File.GetLastWriteTime(files[i]);
                                System.IO.FileInfo fi = new System.IO.FileInfo(files[i]);
                                string filesize = fi.Length.ToString();
                                fi = null;
                                string updatestr = "";
                                if (update != null)
                                {
                                    updatestr = update.Year.ToString() + "/" + update.Month.ToString() + "/" + update.Day.ToString() + " " + update.Hour.ToString() + ":" + (update.Minute < 10 ? "0" : "") + update.Minute.ToString() + ":" + (update.Second < 10 ? "0" : "") + update.Second.ToString();
                                }
                                string pathfile = System.IO.Path.GetDirectoryName(files[i]);
                                string filename = "";
                                string[] filepaths = files[i].Split(new Char[] { '\\' });
                                if (filepaths != null)
                                {
                                    filename = filepaths[filepaths.Length - 1];
                                }
                                sw.WriteLine(pathfile + "," + filename + "," + updatestr);

                            }
                        }
                    }
                }
            }
            catch { }
            return path1;
        }
    }
}
