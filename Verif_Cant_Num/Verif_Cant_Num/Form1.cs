namespace Verif_Cant_Num
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Escriba una palabra");
                return;
            }

            // Verificar que solo tenga letras
            foreach (char c in texto)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Error: Solo se permiten letras");
                    return;
                }
            }

            // Si pasa la validación
            int cantidadLetras = texto.Length;

            MessageBox.Show("La palabra tiene " + cantidadLetras + " letras");
        }
    }
}
