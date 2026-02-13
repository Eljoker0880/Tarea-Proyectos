namespace DataTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
