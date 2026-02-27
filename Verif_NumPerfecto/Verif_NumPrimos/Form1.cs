namespace Verif_NumPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita sonido

                if (int.TryParse(maskedTextBox1.Text.Trim(), out int numero))
                {
                    bool resultado = EsPerfecto(numero);

                    MessageBox.Show(resultado
                        ? "Es un número perfecto"
                        : "No es un número perfecto");
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido");
                }
            }
        }

        private bool EsPerfecto(int numero)
        {
            if (numero <= 1)
                return false;

            int suma = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }

            return suma == numero;
        }

    }
}
