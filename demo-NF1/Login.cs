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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.USUARI.Text == "JAUME" && this.PASSWORD.Text == "PASSWORD")
            {
                MessageBox.Show("HOLA JAUME");
                Form1 FORMULARI_1 = new Form1();
                FORMULARI_1.Show();
                this.Hide();
            }
            else MessageBox.Show("login incorrecte!");
        }
    }
}
