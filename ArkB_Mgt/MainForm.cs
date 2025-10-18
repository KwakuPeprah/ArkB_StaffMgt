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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addStaff1.Visible = false;
            salary1.Visible = false;
        }

        private void btnAddStaffm_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addStaff1.Visible = true;
            salary1.Visible = false;
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addStaff1.Visible = false;
            salary1.Visible = true;
        }
    }
}
