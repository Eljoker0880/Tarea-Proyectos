using System.Diagnostics.Eventing.Reader;

namespace sumar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (double.TryParse(textBox1.Text, out num1) &&
                double.TryParse(textBox2.Text, out num2))
            {
                double resultado = num1 + num2;
                label1.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show ("Por favor, escribe solo números válidos");
            }
        }
    }
}
