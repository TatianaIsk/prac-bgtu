namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitManuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.Owner = this;
            newChild.ShowDialog();
        }
    }
}