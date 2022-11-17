namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.Owner= this;
                    newChild.ShowDialog();
                    newChild.Text += "";
                    break;

                case "Cascade":
                    break;

                case "Title":
                    break;
            }
        }
    }
}