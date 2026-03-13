namespace MdiContainerPractica
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registroDeDatosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistPers frm = new RegistPers();
            frm.Show();

        }

        private void conversorDeDivisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvDiv frm = new ConvDiv();
            frm.Show();
        }

        private void serieDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerFib frm = new SerFib();
            frm.Show();
        }
    }
}
