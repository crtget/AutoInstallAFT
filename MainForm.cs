using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AutoInstallAFT
{
    public partial class MainForm : Form
    {
        public string path;
        public MainForm()
        {
            InitializeComponent();
        }

        public void unZip(string zippath)
        {
            string commmand = $"x -aoa {zippath} -o{path}";
            var process = new Process
            {
                StartInfo =
                {
                    FileName = @"Res\7-Zip\7z.exe",
                    Arguments = commmand,
                    WindowStyle = ProcessWindowStyle.Normal,
                    CreateNoWindow = false,
                }
            };
            process.Start();
            logBox.AppendText("开始解压,请耐心等待" + Environment.NewLine);
            unzip.Visible = !unzip.Visible;
            pathBox.Visible = !pathBox.Visible;
            selectPath.Visible = !selectPath.Visible;
            process.WaitForExit();
            process.Close();
            unzip.Visible = !unzip.Visible;
            pathBox.Visible = !pathBox.Visible;
            selectPath.Visible = !selectPath.Visible;
        }

        private void selectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };
            fbd.ShowDialog();
            pathBox.Text = Directory.GetDirectoryRoot(fbd.SelectedPath);
            path = pathBox.Text;
        }

        private void unzip_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pathBox.Text))
            {
                try
                {
                    var files = Directory.GetFiles("Res");
                    for (int i = 0; i < files.Length; i++)
                    {
                        logBox.AppendText("已检测到压缩包:" + files[i] + Environment.NewLine);
                    }
                    string covfilepaht = $"\"{files[0]}\"";
                    unZip(covfilepaht);
                }
                catch (Exception)
                {
                    MessageBox.Show("资源文件丢失，请勿删除Res文件夹");
                    throw;
                }
            }
        }
    }
}
