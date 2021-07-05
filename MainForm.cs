using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

namespace FreeandPremium
{
    public partial class MainForm : Form
    {
        string hwid = WindowsIdentity.GetCurrent().User.Value;
        WebClient loginshit = new WebClient();
        bool premium = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HttpWebRequest.DefaultWebProxy = new WebProxy(); // disable default proxy to hide from http debuggers
            string hwidshit = loginshit.DownloadString("https://pastebin.com/raw/5XVM2Rmm");
            if (hwidshit.Contains(hwid))
            {
                premium = true;
            }
        }

        private void ggb_Click(object sender, EventArgs e)
        {
            // Free and Premium
            Process.Start("https://www.google.com/");   
        }

        private void fbb_Click(object sender, EventArgs e)
        {
            // Free and Premium
            Process.Start("https://www.facebook.com/");            
        }

        private void wab_Click(object sender, EventArgs e)
        {
            // Free and Premium
            Process.Start("https://www.whatsapp.com/");            
        }

        private void twb_Click(object sender, EventArgs e)
        {
            // Premium
            if (premium == true)
            {
                Process.Start("https://twitter.com/");
            }
            else
            {
                MessageBox.Show("You're not Premium !");
            }
        }

        private void ytb_Click(object sender, EventArgs e)
        {
            // Premium
            if (premium == true)
            {
                Process.Start("https://www.youtube.com/");
            }
            else
            {
                MessageBox.Show("You're not Premium !");
            }
        }

        private void igb_Click(object sender, EventArgs e)
        {
            // Premium
            if (premium == true)
            {
                Process.Start("https://www.instagram.com/");
            }
            else
            {
                MessageBox.Show("You're not Premium !");
            }
        }
    }
}
