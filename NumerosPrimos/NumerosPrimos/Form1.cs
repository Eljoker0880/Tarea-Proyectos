namespace NumerosPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            listBoxPrimos.Items.Clear(); // Limpiar lista anterior

            if (!int.TryParse(textBoxInicio.Text.Trim(), out int inicio) ||
                !int.TryParse(textBoxFin.Text.Trim(), out int fin))
            {
                MessageBox.Show("Ingrese números válidos");
                return;
            }

            if (inicio > fin)
            {
                MessageBox.Show("El número inicial no puede ser mayor que el final");
                return;
            }

            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    listBoxPrimos.Items.Add(i);
                }
            }
        }
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
