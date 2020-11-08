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
using System.Collections;

namespace SIENA
{
    public partial class AccountRecovery : Form
    {
        public AccountRecovery()
        {
            InitializeComponent();
        }

        private void btnForgotSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SienaDB.mdf;Integrated Security=True"); //creates connection to database   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Users WHERE username='" +txtForgotUname.Text+"'", con); //checks if values entered are in database

            DataTable dt = new DataTable(); //creates a virtual table for the check  
            DataView dv = new DataView(dt);

            sda.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid username or password");
            }
            else
            {
                PasswordGenerator pg = new PasswordGenerator();

                string newPassword = pg.RandomPassword();

                DataClassDataContext dbCtx = new DataClassDataContext();

                var getData = (

                    from x in dbCtx.Users
                    where x.Username.Equals(txtForgotUname.Text)
                    select x
                ).ToList().Last();

                getData.Password = newPassword;

                try
                {
                    dbCtx.SubmitChanges();
                    new EmailClass().SendPasswordResetEmail(getData);
                    MessageBox.Show("Your password has been reset.\nPlease check your email for the new password.");
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.ToString());
                }
            }
        }

        private void AccountRecovery_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
