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
using System.IO;

namespace ArkB_Mgt
{

    public partial class AddStaff : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CJ0V0EH\\KWAKU_SQLSERVER;Initial Catalog=ArkB_Staff;Integrated Security=True");

        public AddStaff()
        {
            InitializeComponent();

            //TO DISPLAY STAFF DATA IN DATAGRIDVIEW
            displayStaffData();
        }

        public void displayStaffData()
        {
            StaffData ed = new StaffData();
            List<StaffData> listData = ed.staffListData();

            dataGridView1.DataSource = listData;
        }
        private void btnAdd_AddStaff_Click(object sender, EventArgs e)
        {
            if (txtEmpID_AddStaff.Text == ""
                || txtFullName_AddStaff.Text == ""
                || cboGender_AddStaff.Text == ""
                || txtPhone_AddStaff.Text == ""
                || cboPosition_AddStaff.Text == ""
                || cboStatus_AddStaff.Text == ""
                || AddStaffPicture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        string checkEmployeeID = "SELECT COUNT(*) FROM staff WHERE employee_id = @empID";

                        using (SqlCommand checkEm = new SqlCommand(checkEmployeeID, conn))
                        {
                            checkEm.Parameters.AddWithValue("@empID", txtEmpID_AddStaff.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(txtEmpID_AddStaff.Text.Trim() + "Employee ID already exists",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Code to add new staff member goes here
                                DateTime today = DateTime.Today;
                                string insertStaff = "INSERT INTO staff" +
                                    " (employee_id, full_name, gender, contact_number, position, image, insert_date, status)" +
                                     "VALUES(@employeeID, @fullName, @gender, @contactNum, @position, @image, @insertData, @status)";

                                string path = Path.Combine(@"C:\Users\user\Documents\sweDoc\CSharp\Project_Work\ArkB_Naturals\ArkB_Mgt\Directory\"
                                   + txtEmpID_AddStaff.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(AddStaffPicture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertStaff, conn))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", txtEmpID_AddStaff.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", txtFullName_AddStaff.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", cboGender_AddStaff.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", txtPhone_AddStaff.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", cboPosition_AddStaff.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@insertData", today);
                                    cmd.Parameters.AddWithValue("@status", cboStatus_AddStaff.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayStaffData();

                                    MessageBox.Show("Staff Added Successfully!",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg;*.jpeg)|*.png;*.bmp;*.gif";

                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    AddStaffPicture.ImageLocation = imagePath;

                }
            }

            catch (Exception ex)
            { 
                MessageBox.Show("An error occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }
    }
}
