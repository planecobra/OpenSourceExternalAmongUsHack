using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auth.GG_Winform_Example;

namespace BlitzAmongUsHack
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (API.Register(Username.Text, Password.Text, Email.Text, Key.Text))
            {
                //Put code here of what you want to do after successful login
                MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
