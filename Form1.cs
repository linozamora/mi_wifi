using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Net;
using System.IO;


namespace MiWIFI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = Dns.GetHostName();
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
               
            }
            textBox2.Text = localIP;

            //foreach (IPAddress adress in Dns.GetHostAddresses(Dns.GetHostName()))
            //{
            //    textBox2.Text = "" + adress;
            //}

        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

 

        private void button1_Click(object sender, EventArgs e)
        {           
            Form Form1 = new Cambiar_Contraseña();
            Form1.Show();                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
