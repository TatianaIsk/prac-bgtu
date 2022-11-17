namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else {
                MessageBox.Show("Выбирите элемент из списка или введите новый");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            while(memberList.CheckedIndices.Count > 0)
            {
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
            }
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }
    }
}