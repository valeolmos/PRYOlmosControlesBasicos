using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRYOlmosControlesBasicos
{
    public partial class Form1 : Form
    {
        public Form1()
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
            MessageBox.Show("Bienvenido");
        }
    }
}
