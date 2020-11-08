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

            this.txtPassword.AutoSize = false;
            this.txtPassword.Size = new Size(this.txtPassword.Size.Width, 50);
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SienaDB.mdf;Integrated Security=True"); //creates connection to database   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Users WHERE username='" + txtUname.Text + "' AND password='" + txtPassword.Text + "'", con); //checks if values entered are in database
            
            DataTable dt = new DataTable(); //creates a virtual table for the check  
            DataView dv = new DataView(dt);

            sda.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid username or password");
            }
            else
            {
                
                DataTable enabledCheck = dv.ToTable(true, "Enabled");

                if (!enabledCheck.Rows[0][0].ToString().Equals("Yes"))

                {
                    MessageBox.Show("Your account has not yet been activated.\nPlease contact your administrator.");
                }
                else
                {
                    DataTable checkUserType = dv.ToTable(true, "User Type");

                    if (checkUserType.Rows[0][0].ToString().Equals("Administrator"))
                    {
                        MessageBox.Show("Welcome " + dt.Rows[0][3].ToString() + "\n You are an admin");
                        this.Visible = false;
                        new AdminPanel().Show();
                    }

                    else if (checkUserType.Rows[0][0].ToString().Equals("Student"))
                    {
                        MessageBox.Show("Welcome " + dt.Rows[0][3].ToString());
                    }
                }
            }
        }

        private void labelGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panels.RegisterPanel registerform = new Panels.RegisterPanel();
            registerform.Show();
        }

        private void labelGoToSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.Yellow;
        }

        private void labelGoToSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.White;
        }

        private void forgotPWlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            new AccountRecovery().Show();
        }
    }
}
