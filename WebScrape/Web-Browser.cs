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
    public partial class Web_Browser : Form
    {
        Form1 form = new Form1();

        public Web_Browser()
        {
            InitializeComponent();
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Browser_DocumentCompleted);
        }

        private void Browser_DocumentCompleted(Object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.Document.Body.MouseDown += new HtmlElementEventHandler(Body_MouseDown);
        }
        void Body_MouseDown(Object sender, HtmlElementEventArgs e)
        {
            if (e.MouseButtonsPressed == MouseButtons.Left)
            {
                HtmlElement element = webBrowser.Document.GetElementFromPoint(e.ClientMousePosition);
                string tagName = element.TagName;
                string className = element.GetAttribute("className");
                HtmlElementCollection elements = webBrowser.Document.GetElementsByTagName(tagName);
                foreach (HtmlElement elm in elements)
                {
                    Console.Write("Title: ");
                    Console.WriteLine(elm.InnerText);
                }
            }
            text_url.Text = form.AddOwnedForm(Text.)
        }
    }
}
