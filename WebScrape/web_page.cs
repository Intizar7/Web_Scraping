using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScrape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        Web_Browser browser = new Web_Browser();
        public static string address;
        private void btn_url_Click(object sender, EventArgs e)
        {
            address = txt_url.Text;
            this.Hide();
            browser.webBrowser.Url = new Uri(address);
            browser.ShowDialog();
        }
    }
}
