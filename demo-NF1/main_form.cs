using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_NF1
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            subform2 subForm = new subform2();
            subForm.TopLevel = false;

            panel1.Controls.Add(subForm);
            subForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            subform1 subForm = new subform1();
            subForm.TopLevel = false;

            panel1.Controls.Add(subForm);
            subForm.Show();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            subform1 subForm = new subform1();
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;

            panel1.Controls.Add(subForm);
            subForm.Show();
        }
    }
}
