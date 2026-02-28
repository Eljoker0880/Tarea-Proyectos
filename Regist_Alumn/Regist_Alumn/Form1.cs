namespace Regist_Alumn
{
    public partial class Form1 : Form
    {
        string[] codigos = new string[100];
        string[] nombres = new string[100];
        double[] promedios = new double[100];
        int contador = 0;

        void Mostrar()
        {
            dgvAlumnos.Rows.Clear();

            for (int i = 0; i < contador; i++)
            {
                dgvAlumnos.Rows.Add(codigos[i], nombres[i], promedios[i]);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (contador < 100)
            {
                codigos[contador] = txtCodigo.Text;
                nombres[contador] = txtNombre.Text;
                promedios[contador] = Convert.ToDouble(txtPromedio.Text);
                contador++;

                Mostrar();

                txtCodigo.Clear();
                txtNombre.Clear();
                txtPromedio.Clear();
            }
            else
            {
                MessageBox.Show("Límite alcanzado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigoEliminar = txtCodigo.Text;

            for (int i = 0; i < contador; i++)
            {
                if (codigos[i] == codigoEliminar)
                {
                    for (int j = i; j < contador - 1; j++)
                    {
                        codigos[j] = codigos[j + 1];
                        nombres[j] = nombres[j + 1];
                        promedios[j] = promedios[j + 1];
                    }

                    contador--;
                    Mostrar();
                    MessageBox.Show("Alumno eliminado");
                    return;
                }
            }

            MessageBox.Show("Alumno no encontrado");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = 0; j < contador - 1; j++)
                {
                    if (promedios[j] > promedios[j + 1])
                    {
                        double auxProm = promedios[j];
                        promedios[j] = promedios[j + 1];
                        promedios[j + 1] = auxProm;

                        string auxCod = codigos[j];
                        codigos[j] = codigos[j + 1];
                        codigos[j + 1] = auxCod;

                        string auxNom = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = auxNom;
                    }
                }
            }

            Mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBuscar = txtCodigo.Text;

            for (int i = 0; i < contador; i++)
            {
                if (codigos[i] == codigoBuscar)
                {
                    MessageBox.Show("Nombre: " + nombres[i] +
                                    "\nPromedio: " + promedios[i]);
                    return;
                }
            }

            MessageBox.Show("Alumno no encontrado");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
