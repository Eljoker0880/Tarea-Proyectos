namespace opciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                label2.Text = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                label2.Text = radioButton3.Text;

                return;
            }
            }
        }
    }

