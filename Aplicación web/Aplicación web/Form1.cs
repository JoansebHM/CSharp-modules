using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void tsmBackwards_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void tsmForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();

        }

        private void tsmRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void tsmHome_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://google.com");
        }

        private void tsmSearch_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtBusqueda.Text);
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtBusqueda.Text = webBrowser.Url.ToString();
        }
    }
}
