namespace Comb_Uni_Log
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            string[] unidades = { "Metros", "Centímetros", "Pulgadas" };
            comboBox1.Items.AddRange(unidades);
            comboBox2.Items.AddRange(unidades);

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor;

            // Validar número
            if (!double.TryParse(textBox1.Text, out valor))
            {
                MessageBox.Show("Ingrese un número válido");
                return;
            }

            // Validar selección
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Seleccione ambas unidades");
                return;
            }

            string unidadEntrada = comboBox1.SelectedItem.ToString();
            string unidadSalida = comboBox2.SelectedItem.ToString();

            double valorEnMetros = 0;

            // Convertir entrada a METROS
            if (unidadEntrada == "Metros")
                valorEnMetros = valor;

            else if (unidadEntrada == "Centímetros")
                valorEnMetros = valor / 100;

            else if (unidadEntrada == "Pulgadas")
                valorEnMetros = valor * 0.0254;

            double resultado = 0;

            // Convertir de METROS a salida
            if (unidadSalida == "Metros")
                resultado = valorEnMetros;

            else if (unidadSalida == "Centímetros")
                resultado = valorEnMetros * 100;

            else if (unidadSalida == "Pulgadas")
                resultado = valorEnMetros / 0.0254;
            // Obtener símbolo de unidad
            string simbolo = "";

            if (unidadSalida == "Metros")
                simbolo = " m";

            else if (unidadSalida == "Centímetros")
                simbolo = " cm";

            else if (unidadSalida == "Pulgadas")
                simbolo = " in";


            // 👇 MOSTRAR EN LABEL
            label1.Text = resultado.ToString("0.####") + simbolo;
        }

    
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
