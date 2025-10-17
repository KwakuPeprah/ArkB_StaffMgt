using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ArkB_Mgt
{
    public partial class RegistrationForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CJ0V0EH\\KWAKU_SQLSERVER;Initial Catalog=ArkB_Staff;Integrated Security=True");
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSign_IN_Click(object sender, EventArgs e)
        {
            Login Log1 = new Login();
            Log1.Show();
            this.Hide();
        }

        private void cbShowPassword_SignUp_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = cbShowPassword_SignUp.Checked ? '\0' : '•';
        }

        private void btnSign_UP_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        // TO CHECK IF THE USER ALREADY EXISTS
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, conn))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + "Has already been taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertCredentials = "INSERT INTO users" +
                                    "(username, password, date_register) " +
                                    "VALUES(@USERNAME, @PASSWORD, @DATEREG)";

                                using (SqlCommand Reg = new SqlCommand(insertCredentials, conn))
                                {
                                    Reg.Parameters.AddWithValue("@USERNAME", signup_username.Text.Trim());
                                    Reg.Parameters.AddWithValue("@PASSWORD", signup_password.Text.Trim());
                                    Reg.Parameters.AddWithValue("@DATEREG", today);

                                    Reg.ExecuteNonQuery();
                                    MessageBox.Show("User Registered Successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login Reg1 = new Login();
                                    Reg1.Show();
                                    this.Hide();
                                }


                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
