using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkB_Mgt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegistrationForm Reg1 = new RegistrationForm();
            Reg1.Show();
            this.Hide();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            signin_password.PasswordChar = cbShowPassword.Checked ? '\0' : '•';
        }
    }
}
