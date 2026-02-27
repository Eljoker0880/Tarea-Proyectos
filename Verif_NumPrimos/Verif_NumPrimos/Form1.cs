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
                if (int.TryParse(maskedTextBox1.Text.Trim(), out int numero))
                {
                    bool resultado = EsPrimo(numero);

                    MessageBox.Show(resultado
                        ? "Es primo"
                        : "No es primo");
                }

                e.SuppressKeyPress = true;
            }
        }

        // ?? AQUÍ, dentro de la clase pero fuera del evento
        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    
    }
}
