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
    public partial class Dashboard : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CJ0V0EH\\KWAKU_SQLSERVER;Initial Catalog=ArkB_Staff;Integrated Security=True");

        public Dashboard()
        {
            InitializeComponent();
        }


    }
}
    

