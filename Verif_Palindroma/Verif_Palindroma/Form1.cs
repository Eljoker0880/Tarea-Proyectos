namespace Verif_Palindroma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string texto = textBox1.Text
                    .ToLower()
                    .Replace(" ", "")
                    .Trim();

                string invertido = new string(texto.Reverse().ToArray());

                MessageBox.Show(texto == invertido
                    ? "Es un palíndromo"
                    : "No es un palíndromo");

                e.SuppressKeyPress = true; // ?? evita que agregue salto de línea
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
