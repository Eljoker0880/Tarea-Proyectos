namespace OpenFileDialog_y_SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de texto|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos de texto|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }
    }
}
