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

namespace SIENA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SienaDB.mdf;Integrated Security=True"); //creates connection to database   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM LoginCredentials WHERE username='" + txtUname.Text + "' AND password='" + txtPassword.Text + "'", con); //checks if values entered are in database
            
            DataTable dt = new DataTable(); //creates a virtual table for the check  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Welcome!");
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void lnkForgotPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AccountRecovery().Show();
        }
    }
}
