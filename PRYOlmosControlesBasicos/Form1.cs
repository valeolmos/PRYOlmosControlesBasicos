using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRYOlmosControlesBasicos
{
    public partial class frmEjemplo : Form
    {
        public frmEjemplo()
        {
            InitializeComponent();
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString();
            lblEjeY.Text = e.Y.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void chkRojo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRojo.Checked == true);
           
                lblEjemplo.ForeColor = Color.Red;
               if (chkAzul.Checked == true)
            {
                lblEjemplo.ForeColor = Color.Violet;
            }
            if (chkAmarillo.Checked == true)
            {
                lblEjemplo.ForeColor = Color.Orange;
                    }

             lblEjemplo.ForeColor = Color.Black;

        }

        private void chkAzul_CheckedChanged(object sender, EventArgs e)
        {

            if (chkAzul.Checked == true) ;

            lblEjemplo.ForeColor = Color.Blue;

            lblEjemplo.ForeColor = Color.Black;
        }

        private void chkAmarillo_CheckedChanged(object sender, EventArgs e)
        {

            if (chkAmarillo.Checked == true) ;

            lblEjemplo.ForeColor = Color.Yellow;

            lblEjemplo.ForeColor = Color.Black;
        }
    }
}
