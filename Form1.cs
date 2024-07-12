namespace Latih12_MdiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ChildForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
