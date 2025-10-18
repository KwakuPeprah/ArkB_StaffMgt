using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CJ0V0EH\\KWAKU_SQLSERVER;Initial Catalog=ArkB_Staff;Integrated Security=True");


        public List<StaffData> staffListData()
        {
            List<StaffData> staffList = new List<StaffData>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string selectData = "SELECT * FROM staff WHERE Delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn)) 
                    { 
                        SqlDataReader reader = cmd.ExecuteReader();

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
                            ed.Salary = (int)reader["salary"];
                            ed.Status = reader["status"].ToString();
                            
                            staffListData().Add(ed);
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error opening database connection: " + ex.Message);
                    return staffList; // Return empty list on failure
                }
                finally
                {
                    conn.Close();
                }

            }
            return staffList;
        }
    }
}
