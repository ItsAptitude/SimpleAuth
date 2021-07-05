using Microsoft.Win32;
using System;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

namespace FreeandPremium
{
    public partial class LoginForm : Form
    {
        string hwid = WindowsIdentity.GetCurrent().User.Value;
        WebClient loginshit = new WebClient();


        public LoginForm()
        {
            InitializeComponent();
            HttpWebRequest.DefaultWebProxy = new WebProxy(); // disable default proxy

        }

        private void FreeLoginBtn_Click(object sender, EventArgs e)
        {
            WebClient loginshit = new WebClient();
            string hwidshit = loginshit.DownloadString("https://pastebin.com/raw/wX50fHzk"); // Edit and change to your pastebin
            if (hwidshit.Contains(hwid))
            {
                MessageBox.Show("You have premium version! Go use it!", "https://github.com/ItsAptitude");
            }
            else
            {
                MainForm main = new MainForm();
                this.Hide();
                main.Show();
            }
        }
       

        private void LoginForm_Load(object sender, EventArgs e)
        {
            hwidtextbox.Text = hwid;
            hwid = hwid;
        }

        private void PremiumLoginBtn_Click(object sender, EventArgs e)
        {
            string hwidshit = loginshit.DownloadString("https://pastebin.com/raw/5XVM2Rmm"); // Edit and change to your pastebin
            if (hwidshit.Contains(hwid))
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You don't have premium version!", "https://github.com/ItsAptitude");
            }
        }
    }
}
