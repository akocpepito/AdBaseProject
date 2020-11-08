using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SIENA
{
    public partial class ViewUsers : UserControl
    {
        public ViewUsers()
        {
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SienaDB.mdf;Integrated Security=True"); //creates connection to database   
            SqlDataAdapter tableData = new SqlDataAdapter("SELECT * FROM Users", con);

            DataTable dataTable = new DataTable();
            tableData.Fill(dataTable);

            userDataTable.DataSource = dataTable;
        }

        private void userDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
