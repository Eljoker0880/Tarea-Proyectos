using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiContainerPractica
{
    public partial class SerFib : Form
    {
        public SerFib()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int limite = Convert.ToInt32(txtLimite.Text);

            int a = 0;
            int b = 1;

            txtResultado.Text = "";

            while (a <= limite)
            {
                txtResultado.Text += a + " ";

                int siguiente = a + b;
                a = b;
                b = siguiente;
            }
        }
        }
}
