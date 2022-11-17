namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            SpWin.Text = "Windows is cascade";
            // SpWin.Text = "Windows is horizontal";
        }
    }
}