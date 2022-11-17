namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ћы и не сомневались, что вы так думаете!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNo_Click(object sender, EventArgs e)
        {

        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNo.Top -= e.Y;
            btnNo.Left += e.X;
            if(btnNo.Top < -10 || btnNo.Top > 100)
            {
                btnNo.Top = 60;
            }
            if(btnNo.Left < -80 || btnNo.Left > 250)
            {
                btnNo.Left = 120;
            }
        }
    }
}