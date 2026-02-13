namespace elsius_a_Fahrenheit_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius;

            if (!double.TryParse(textBox1.Text, out celsius))
            {
                MessageBox.Show("Solo se permiten números");
                return;
            }

            double fahrenheit = (celsius * 9 / 5) + 32;
            label1.Text = fahrenheit.ToString("0.00") + " °F";
        }
    }
}
