namespace Cronometro
{
    public partial class Form1 : Form
    {
        int tiempoRestante = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; // 1 segundo exacto
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (tiempoRestante > 0)
            {
                tiempoRestante--;

                int minutos = tiempoRestante / 60;
                int segundos = tiempoRestante % 60;

                label1.Text = minutos.ToString() + ":" + segundos.ToString("00");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Tiempo terminado ⏰");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el tiempo:",
                "Configurar Cronómetro",
                "60");

            int tiempo;

            if (int.TryParse(input, out tiempo))
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Desea ingresar el tiempo en minutos?",
                    "Tipo de tiempo",
                    MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    tiempoRestante = tiempo * 60; // minutos a segundos
                }
                else
                {
                    tiempoRestante = tiempo; // segundos directos
                }

                label1.Text = tiempoRestante.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                timer1.Start();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();          // Detiene el cronómetro
            tiempoRestante = 0;     // Pone el tiempo en 0
            label1.Text = "0:00";   // Muestra 0:00 en pantalla
        }
    }
}
