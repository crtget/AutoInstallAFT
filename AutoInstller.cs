using System;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AutoInstallAFT
{
    public partial class AutoInstller : Form
    {
        public string path;
        public static string divapath;
        public AutoInstller()
        {
            InitializeComponent();
        }

        public void Md5_reckon(string filepath,string s_md5) //md5校验，未测试
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            FileStream fs = new FileStream(filepath,FileMode.Open);
            byte[] fileBytes = md5.ComputeHash(fs);
            fs.Close();
            fs.Dispose();
            GC.Collect();
            StringBuilder fileMD5 = new StringBuilder();
            for (int i = 0; i < fileBytes.Length; i++)
            {
                fileMD5.Append(fileBytes[i].ToString("x2"));
            }
            if (string.Compare(fileMD5.ToString(),s_md5) != 0)
            {
                MessageBox.Show(filepath + "已损坏，请重新下载");
            }
        }


        public void UnZip(string zippath)
        {
            //string commmand = $"x -aoa {zippath} -o{path}";   //覆盖所有
            string commmand = $"x -aos {zippath} -o{path}";   //跳过已有文件
            var process = new Process
            {
                StartInfo =
                {
                    FileName =  Directory.GetCurrentDirectory() + @"\Res\7z.exe",
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
            MessageBox.Show("解压完成，请在FastSegatools中完成联机服务器设置");
            File.Copy("AFT_Online_Stater.exe", path + @"Project DIVA ARCADE FT\AFT在线模式启动器.exe", true);
            FastSegaTools fst = new FastSegaTools();
            fst.ShowDialog(this);
            Process.Start(pathBox.Text);
            logBox.AppendText("安装完成，敬请开始您的DIVA之旅！" + Environment.NewLine);
        }

        private void SelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            fbd.ShowDialog();
            pathBox.Text = Directory.GetDirectoryRoot(fbd.SelectedPath) + "Project DIVA ARCADE FT";
        }

        private void Unzip_Click(object sender, EventArgs e)
        {

            if (pathBox.Text.Trim() == "")
            {
                MessageBox.Show(this, "请选择安装路径！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            divapath = pathBox.Text;
            path = Directory.GetDirectoryRoot(pathBox.Text);

            if (!string.IsNullOrWhiteSpace(path))
            {
                try
                {
                    var files = Directory.GetFiles("Res");
                    string covfilepaht = $"\"{files[5]}\"";
                    UnZip(covfilepaht);
                }
                catch (Exception)
                {
                    MessageBox.Show("资源文件丢失或解压失败,请重新下载或安装7-Zip的依赖库");
                    throw;
                }
            }
        }
    }
}
