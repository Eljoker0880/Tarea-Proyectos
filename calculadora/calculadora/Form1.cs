namespace calculadora
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        string operacion;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(pantalla.Text);
            operacion = "+";

            // Muestra el signo en la pantalla
            pantalla.Text += " + ";
        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {

        }

        private void Numeros_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (pantalla.Text == "0")
                pantalla.Text = boton.Text;
            else
                pantalla.Text += boton.Text;
        }

        private void resta_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(pantalla.Text);
            operacion = "-";

            // Muestra el signo en la pantalla
            pantalla.Text += " - ";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            // Separamos los números usando el signo
            string[] partes;
            double numero2 = 0;
            double resultado = 0;

            if (operacion == "+")
                partes = pantalla.Text.Split('+'); // divide en dos partes
            else
                partes = pantalla.Text.Split('-'); // divide en dos partes

            // Convertimos la segunda parte a número
            if (partes.Length >= 2)
                numero2 = Convert.ToDouble(partes[1].Trim());

            // Calculamos
            if (operacion == "+")
                resultado = numero1 + numero2;
            else if (operacion == "-")
                resultado = numero1 - numero2;

            pantalla.Text = resultado.ToString();
        }
    }
}
