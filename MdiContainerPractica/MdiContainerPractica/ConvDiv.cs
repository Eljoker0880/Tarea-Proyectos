using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiContainerPractica
{
    public partial class ConvDiv : Form
    {
        public ConvDiv()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double cantidad = Convert.ToDouble(txtCantidad.Text);
                double resultado = 0;

                string de = cmbDe.Text;
                string a = cmbA.Text;

                // Tasas aproximadas
                double dolar = 61.75;
                double euro = 70.46;

                if (de == "Peso" && a == "Dólar")
                    resultado = cantidad / dolar;

                else if (de == "Peso" && a == "Euro")
                    resultado = cantidad / euro;

                else if (de == "Dólar" && a == "Peso")
                    resultado = cantidad * dolar;

                else if (de == "Euro" && a == "Peso")
                    resultado = cantidad * euro;

                else if (de == "Dólar" && a == "Euro")
                    resultado = (cantidad * dolar) / euro;

                else if (de == "Euro" && a == "Dólar")
                    resultado = (cantidad * euro) / dolar;

                else
                    resultado = cantidad;

                txtResultado.Text = resultado.ToString();
            }
        }
    }
}
