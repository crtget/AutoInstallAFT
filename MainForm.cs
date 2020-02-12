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

        public void Runtools()
        {
            try
            {
                Process p =Process.Start("FastSegatools With GUI");
                p.WaitForExit();
            }
            catch (Exception)
            {
                MessageBox.Show("fastsegatools 不存在，请下载并放置在本程序目录");
                throw;
            }
        }

        public void UnZip(string zippath)
        {
            string commmand = $"x -aoa {zippath} -o{path}";   //覆盖所有
            //string commmand = $"x -aos {zippath} -o{path}";   //跳过已有文件
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
            MessageBox.Show("安装完成，请在新窗口中完成联机服务器设置");
            Runtools();
        }

        private void SelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };
            fbd.ShowDialog();
            pathBox.Text = Directory.GetDirectoryRoot(fbd.SelectedPath);
            path = pathBox.Text;
        }

        private void Unzip_Click(object sender, EventArgs e)
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
                    UnZip(covfilepaht);
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
