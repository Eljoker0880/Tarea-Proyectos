namespace tabla_de_multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             listBox1.Items.Clear();
            int numero;

            if (int.TryParse(textBox1.Text,out numero))
            {
                for (int i = 1; i <= 12; i++)
                {
                    int resultado = numero * i;
                    listBox1.Items.Add(numero + "X" + i + "=" + resultado);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero valido");
            }
        }
    }
}
