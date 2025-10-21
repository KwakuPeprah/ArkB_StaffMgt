using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; // Added for MessageBox, helpful for debugging data access

namespace ArkB_Mgt
{
    internal class StaffData
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }

        private readonly string connectionString = "Data Source=DESKTOP-CJ0V0EH\\KWAKU_SQLSERVER;Initial Catalog=ArkB_Staff;Integrated Security=True";


        public List<StaffData> staffListData()
        {
            List<StaffData> staffList = new List<StaffData>();

            string selectData = "SELECT * FROM staff WHERE Delete_date IS NULL";

            // Use 'using' blocks to ensure the connection and command are closed and disposed
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StaffData ed = new StaffData();
                                ed.ID = (int)reader["id"];
                                ed.EmployeeID = reader["employee_id"].ToString();
                                ed.Name = reader["full_name"].ToString();
                                ed.Gender = reader["gender"].ToString();
                                ed.Contact = reader["contact_number"].ToString();
                                ed.Position = reader["position"].ToString();
                                ed.Image = reader["image"].ToString();
                                // Check if the Salary column is nullable before casting
                                ed.Salary = reader["salary"] != DBNull.Value ? (int)reader["salary"] : 0;
                                ed.Status = reader["status"].ToString();

                                // *** FIX IS HERE ***
                                staffList.Add(ed);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show a message box if the data retrieval fails
                    MessageBox.Show("Error fetching staff data: " + ex.Message,
                        "Data Retrieval Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return staffList; // Return the empty list on failure
                }
                // 'finally' block is not needed here because the 'using' block handles closing the connection.
            }
            return staffList;
        }

        public List<StaffData> salarystaffListData()
        {
            List<StaffData> staffList = new List<StaffData>();

            string selectData = "SELECT * FROM staff WHERE Delete_date IS NULL";

            // Use 'using' blocks to ensure the connection and command are closed and disposed
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StaffData ed = new StaffData();
                                ed.EmployeeID = reader["employee_id"].ToString();
                                ed.Name = reader["full_name"].ToString();
                                ed.Position = reader["position"].ToString();
                                ed.Salary = reader["salary"] != DBNull.Value ? Convert.ToInt32(reader["salary"]) : 0;


                                staffList.Add(ed);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show a message box if the data retrieval fails
                    MessageBox.Show("Error fetching staff data: " + ex.Message,
                        "Data Retrieval Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return staffList; // Return the empty list on failure
                }
                // 'finally' block is not needed here because the 'using' block handles closing the connection.
            }
            return staffList;
        }
    }
}
