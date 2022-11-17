using Microsoft.VisualBasic.Logging;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Log.Clear();

            double doubleItem = 24.2;


            Log.Text += $"Variant: DOUBLE\n";
            Log.Text += $"Name: {doubleItem.GetType().Name}\n";
            Log.Text += $"Full Name: {doubleItem.GetType().FullName}\n";
            Log.Text += $"Namespace: {doubleItem.GetType().Namespace} \n";
            Log.Text += $"Primetive?: {doubleItem.GetType().IsPrimitive}\n";
            Log.Text += $"Public?: {doubleItem.GetType().IsPublic}\n";
            Log.Text += $"Max Value: {double.MaxValue}\n";
            Log.Text += $"Min Value: {double.MinValue}\n";
            Log.Text += $"Value: {doubleItem}\n";

            Lean lean = new Lean();

            Log.Text += $"Variant: LEAN\n";
            Log.Text += $"Name: {lean.GetType().Name}\n";
            Log.Text += $"FullName: {lean.GetType().FullName}\n";
            Log.Text += $"Namespace: {lean.GetType().Namespace} \n";
            Log.Text += $"Primetive?: {lean.GetType().IsPrimitive}\n";
            Log.Text += $"Public?: {lean.GetType().IsPublic}\n";
        }

        private class Lean
        {
            private int _id { get; set; }
            private int _age { get; set; }
            private string _name { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log.Text += "\nВариант № 2\n";
            ushort value  = 5;
            IntelligenseTypeData<ushort> typeData1 = new IntelligenseTypeData<ushort>();
            Log.Text += typeData1.Intelligence(value);

            Lean lean = new Lean();
            IntelligenseTypeData<Lean> typeData2 = new IntelligenseTypeData<Lean>();
            Log.Text += typeData2.Intelligence(lean);
        }
    }
    }