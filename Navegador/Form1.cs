using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + tBuscar.Text + "&source=hp&ei=XLE8YqOaIu-E1sQP67GwyAI&iflsig=AHkkrS4AAAAAYjy_bFxNPfPewVI2APH1Xp5SjybpYg55&ved=0ahUKEwijuMrKqd_2AhVvgpUCHesYDCkQ4dUDCAc&uact=5&oq=" + tBuscar.Text + "&gs_lcp=Cgdnd3Mtd2l6EAMyCwguEIAEELEDEIMBMggILhCABBCxAzIICC4QgAQQsQMyCAguEIAEELEDMggIABCABBCxAzIICAAQgAQQsQMyCAguEIAEELEDMggIABCABBCxAzIICC4QgAQQsQMyCAguEIAEELEDOgsIABCABBCxAxCDAToICC4QsQMQgwE6BQguEIAEOgUIABCABDoOCC4QgAQQsQMQxwEQowI6EQguEIAEELEDEIMBEMcBENEDOg4ILhCABBCxAxCDARDUAjoICAAQsQMQgwE6DgguEIAEELEDEMcBEK8BUABY9wZgzg5oAHAAeACAAcUCiAG5BpIBBzEuMy4wLjGYAQCgAQE&sclient=gws-wiz");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void bAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void bVer_Click(object sender, EventArgs e)
        {
            bBuscar.Visible = !bBuscar.Visible;
        }

        private void bLetraAmarillo_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bLetraRosa_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Pink;
        }

        private void bIr_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBuscar.Text)) return;

            if (tBuscar.Equals("about:blank")) return;
     
            if (!tBuscar.Text.StartsWith("http://") &&
                !tBuscar.Text.StartsWith("htpps://"))    
            {
                tBuscar.Text = "http://" + tBuscar.Text;

                try
                {
                    webBrowser1.Navigate(new Uri(tBuscar.Text));
                }
                catch
                {
                    MessageBox.Show("Se produjo un error.");
                }

            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void bWebBrowser_Click(object sender, EventArgs e)
        {
           webBrowser1.BackColor = Color.Violet;
        }
    }
}
