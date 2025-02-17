namespace demo_NF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prem Ok per continuar", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }
    }
}
