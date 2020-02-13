using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using AutoInstallAFT.Properties;
using System.Threading.Tasks;

namespace AutoInstallAFT
{
    public partial class FastSegaTools : Form
    {
        public string server, subnet;
        public WindowsFormsSynchronizationContext sync = new WindowsFormsSynchronizationContext();

        [DllImport("KERNEL32.DLL", EntryPoint = "WritePrivateProfileStringW",
     SetLastError = true,
     CharSet = CharSet.Unicode, ExactSpelling = true,
     CallingConvention = CallingConvention.StdCall)]
        private static extern int WritePrivateProfileStringW(
     string lpAppName,
     string lpKeyName,
     string lpString,
     string lpFilename);

        public FastSegaTools()
        {
            InitializeComponent();
        }

        private void Setini_Click(object sender, EventArgs e)
        {

            server = serverBox.Text;
            subnet = subnetBox.Text.Remove(subnetBox.Text.LastIndexOf('.') + 1) + "0";
            var inipath = AutoInstller.divapath + "/" + "segatools.ini";

            if (server.Trim() == "" || subnet.Trim() == "")
            {
                MessageBox.Show(this, "未输入服务器或本机IP地址！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                System.Net.IPAddress.Parse(subnetBox.Text);
            }
            catch
            {
                MessageBox.Show(this, "请输入正确的IP地址！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (subnet == "localhost" || subnet == "127.0.0.1")
            {
                MessageBox.Show(this, "不接受本地本地环回地址！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (!File.Exists(inipath))
            {
                try
                {
                    File.WriteAllText(inipath, Resources.segatools_ini);
                }
                catch
                {
                    throw new Exception(@"无法在当前目录下保存文件！");
                }
            }

            WriteSetting(inipath);
            MessageBox.Show(this, "操作完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void WriteSetting(string path)
        {
            WritePrivateProfileStringW("dns", "default", server, path);
            WritePrivateProfileStringW("keychip", "subnet", subnet, path);

        }

        private void serverBox_Leave(object sender, EventArgs e)
        {
            if (serverBox.Text.Trim() != "")
            {
                TestServer(serverBox.Text);
            }
        }

        private void TestServer(string server)
        {
            Ping pinger = null;
            var delay = -1;

            Task.Run(() =>
            {
                try
                {
                    pinger = new Ping();
                    var reply = pinger.Send(server);
                    var pingRelied = reply.Status == IPStatus.Success;
                    if (pingRelied)
                        delay = (int)reply.RoundtripTime;
                    else
                        delay = -1;
                }
                catch (PingException)
                {
                    // Discard PingExceptions and return false;
                }
                finally
                {
                    pinger?.Dispose();
                }


                sync.Send(ShowDelay, delay);
            });



        }

        public void ShowDelay(object o)
        {
            int delay = (Int32)o;
            serverLabel.Text = string.Format("服务器地址：{0}ms", delay);
        }


    }
}
