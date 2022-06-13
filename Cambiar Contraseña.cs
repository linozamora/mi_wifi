using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace MiWIFI
{
    public partial class Cambiar_Contraseña : Form
    {
        public Cambiar_Contraseña()
        {
            InitializeComponent();
          
        }

        private void Cambiar_Contraseña_Load(object sender, EventArgs e)
        {
            Dns.GetHostName();
            foreach (IPAddress adress in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                toolStripTextBox1.Text = "" + adress;
                webBrowser1.Navigate(toolStripTextBox1.Text);
            }         
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario: admin, Contraseña : admin ");
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }
        
        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);

                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch (Exception ex)
            { }

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
