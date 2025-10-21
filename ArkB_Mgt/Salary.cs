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

    public partial class Salary : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CJ0V0EH\\KWAKU_SQLSERVER;Initial Catalog=ArkB_Staff;Integrated Security=True");

        public Salary()
        {
            InitializeComponent();
            displayStaffSalary();
            disabledfields();
        }

        public void disabledfields()
        {
            txtSalary_employeeID.Enabled = false;
            txtSalary_fullname.Enabled = false;
            txtSalary_position.Enabled = false;

        }
        public void displayStaffSalary()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> staffList = ed.salarystaffListData();

            dataGridView1.DataSource = staffList;
        }


        private void btnUpdate_Salary_Click(object sender, EventArgs e)
        {
            if (txtSalary_employeeID.Text == ""
                || txtSalary_fullname.Text == ""
                || txtSalary_position.Text == ""
                || txtSalary.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update this salary?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        try
                        {
                            conn.Open();
                            DateTime today = DateTime.Today;

                            string updatesalary = "UPDATE staff SET salary = @salary, update_date = @updateDate WHERE employee_id = @empid";

                            using(SqlCommand cmd = new SqlCommand(updatesalary, conn))
                            {
                                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                                cmd.Parameters.AddWithValue("@updateDate", today);
                                cmd.Parameters.AddWithValue("@empid", txtSalary_employeeID.Text);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                displayStaffSalary();

                                MessageBox.Show("Salary Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                        finally
                        {
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                }
            }
        }

        public void clearFields()
        {
            txtSalary_employeeID.Clear();
            txtSalary_fullname.Clear();
            txtSalary_position.Clear();
            txtSalary.Clear();
        }   


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtSalary_employeeID.Text = row.Cells[0].Value.ToString();
                txtSalary_fullname.Text = row.Cells[1].Value.ToString();
                txtSalary_position.Text = row.Cells[2].Value.ToString();
                txtSalary.Text = row.Cells[3].Value.ToString();
            }
         }

        private void btnClear_Salary_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
