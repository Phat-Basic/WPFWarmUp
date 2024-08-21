using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace _2212453_NgoBaTai_BTVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strURL = "mailto:2212437@dlu.edu.vn";
            this.linkLabel1.Links.Add(0, strURL.Length, strURL);
            strURL = "https://2212437.blogspot.com/";
            this.linkLabel2.Links.Add(0, strURL.Length, strURL);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=hello");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("https://"))
                Process.Start(strURL);
        }

    }
}
