using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PlanariaBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private WebBrowser getCurrentBrowser()
        {
            return (webBrowser1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void gotoURL_Click(object sender, EventArgs e)
        //{
        //}

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string source = ("source.txt");
            StreamWriter writer = File.CreateText(source);
            writer.Write(getCurrentBrowser().DocumentText);
        }

        private void gotoURL_Click_1(object sender, EventArgs e)
        {
            string webPage = urlText.Text.Trim();
            webBrowser1.Navigate(webPage);
        }
    }
}
