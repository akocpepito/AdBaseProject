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

namespace SIENA.Panels
{
    public partial class RegisterPanel : Form
    {
        public RegisterPanel()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // remove the focus from the textboxes
            this.ActiveControl = label1;
        }

        private void textBoxFirstname_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                textBoxFirstname.Text = "";
                textBoxFirstname.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstname_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                textBoxFirstname.Text = "first name";
                textBoxFirstname.ForeColor = Color.Gray;
            }
        }

        private void textBoxLastname_Enter(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                textBoxLastname.Text = "";
                textBoxLastname.ForeColor = Color.Black;
            }
        }

        private void textBoxLastname_Leave(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                textBoxLastname.Text = "last name";
                textBoxLastname.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email address"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email address") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "email address";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
            {
                textBoxUsername.Text = "username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxPasswordConfirm_Enter(object sender, EventArgs e)
        {
            String cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                textBoxPasswordConfirm.Text = "";
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
                textBoxPasswordConfirm.ForeColor = Color.Black;
            }
        }

        private void textBoxPasswordConfirm_Leave(object sender, EventArgs e)
        {
            String cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") ||
                cpassword.ToLower().Trim().Equals("password") ||
                cpassword.Trim().Equals(""))
            {
                textBoxPasswordConfirm.Text = "confirm password";
                textBoxPasswordConfirm.UseSystemPasswordChar = false;
                textBoxPasswordConfirm.ForeColor = Color.Gray;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }


        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

 

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            
                checkTextBoxesValues();


                




/*

                if (textBoxFirstname.Text.Equals("first name") || textBoxLastname.Text.Equals("last name") || textBoxEmail.Text.Equals("email address"))
                MessageBox.Show("Please enter your details.");

            newUser.Username = textBoxUsername.Text;
            newUser.Password = textBoxPassword.Text;
  */          
            
            // add a new user
            /*
              DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`firstname`, `lastname`, `emailaddress`, `username`, `password`) VALUES (@fn, @ln, @email, @usn, @pass)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirstname.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastname.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            


            // open the connection
            db.openConnection();

             // check if the textboxes contains the default values 
            if (!checkTextBoxesValues())
            {
                // check if the password equal the confirm password
                if (textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
                {
                    // check if this username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }



            // close the connection
            db.closeConnection();
        */



        }

        // checks if the username already exists
        private Boolean checkUnameExisting()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SienaDB.mdf;Integrated Security=True"); //creates connection to database   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Users WHERE username='" + textBoxUsername.Text + "'", con); //checks if values entered are in database

            DataTable dt = new DataTable(); //creates a virtual table for the check  

            sda.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        // check if the textboxes contains the default values
        private void checkTextBoxesValues()
        {
            String fname = textBoxFirstname.Text;
            String lname = textBoxLastname.Text;
            String email = textBoxEmail.Text;
            String uname = textBoxUsername.Text;
            String pass = textBoxPassword.Text;

            if (fname.Equals("first name") || lname.Equals("last name") ||
                email.Equals("email address") || uname.Equals("username")
                || pass.Equals("password"))
            {
                MessageBox.Show("Please fill in all the details.", "Entry error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (checkUnameExisting())
                {
                    if (!textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
                    {
                        MessageBox.Show("Username is already existing.\nPassword and Confirm password do not match.", "Entry error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Username is already existing.", "Entry error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
                    {
                        MessageBox.Show("Password and Confirm password do not match.", "Entry error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // code continues
                    }
                }
            }
        }

        private void labelGoToLogin_MouseEnter(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.Yellow;
        }

        private void labelGoToLogin_MouseLeave(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.White;
        }

        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }
    }
}
