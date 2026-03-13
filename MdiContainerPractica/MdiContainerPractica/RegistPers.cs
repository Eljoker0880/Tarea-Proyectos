using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiContainerPractica
{
    public partial class RegistPers : Form
    {
        public RegistPers()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Add(
                txtNombre.Text,
                txtApellido.Text,
                txtEdad.Text,
                txtSexo.Text,
                txtTelefono.Text,
                txtDireccion.Text,
                txtCiudad.Text,
                txtPais.Text,
                txtCorreo.Text,
                txtFechaNacimiento.Text,
                txtEstadoCivil.Text,
                txtOcupacion.Text
            );
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea eliminar todos los registros?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                dgvPersonas.Rows.Clear();
            }
        }
    }
}
