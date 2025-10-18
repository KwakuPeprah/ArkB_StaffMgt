using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkB_Mgt
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CJ0V0EH\\KWAKU_SQLSERVER;Initial Catalog=ArkB_Staff;Integrated Security=True");

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(signin_username.Text == "" || signin_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        string selectUser = "SELECT * FROM users WHERE username = @user AND password = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectUser, conn))
                        {
                            cmd.Parameters.AddWithValue("@user", signin_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", signin_password.Text.Trim());
                            
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Proceed to the next form or main application window

                                MainForm mForm1 = new MainForm();
                                mForm1.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}
