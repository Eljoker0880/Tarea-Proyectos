namespace VerificarNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;

            if (!int.TryParse(textBox1.Text, out numero))
            {
                MessageBox.Show("Solo se permiten números");
            }
        }
    }
}
