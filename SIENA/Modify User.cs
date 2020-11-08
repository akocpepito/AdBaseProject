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
    public partial class Modify_User : UserControl
    {
        public Modify_User()
        {
            InitializeComponent();
        }

        private void btnSearchBox_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SienaDB.mdf;Integrated Security=True"); //creates connection to database   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Users WHERE Username='" + txtSearchBox.Text + "'", con); //checks if values entered are in database

            DataTable dt = new DataTable(); //creates a virtual table for the check  
            DataView dv = new DataView(dt);

            sda.Fill(dt);
            //con.Close();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("User not found.");
            }
            else
            {
                DataClassDataContext dbctx = new DataClassDataContext();

                var getData =
                    (
                    from x in dbctx.Users
                    where x.Username.Equals(txtSearchBox.Text)
                    select x
                    ).ToList().Last();

                txtEmail.Text = getData.Email_address;
                txtFname.Text = getData.First_Name;
                txtLname.Text = getData.Last_Name;
                txtMname.Text = getData.Middle_Name;
                txtMobile.Text = getData.Mobile;
                txtPwd.Text = getData.Password;
                txtUname.Text = getData.Username;
                rtbAddress.Text = getData.Address;

                if(getData.BirthDate.HasValue)
                dtpBirthDate.Value = getData.BirthDate.Value;
                
                if(getData.Year_Joined.HasValue)
                dtpJoined.Value = getData.Year_Joined.Value;


                if(getData.Course !=null)
                cbCourse.Text = getData.Course;
                
                if(getData.Department !=null)
                cbDept.Text = getData.Department.ToString();

                if (getData.Gender != null)
                {
                    if (getData.Gender.Equals("Male"))
                    {
                        rbMale.Checked = true;
                    }
                    else if (getData.Gender.Equals("Female"))
                    {
                        rbFemale.Checked = true;
                    }
                }

                if (getData.Enabled.Equals("Yes"))
                {
                    checkEnabled.Checked = true;
                }
                else if (getData.Enabled.Equals("No"))
                {
                    checkEnabled.Checked = false;
                }

                if (getData.User_Type.Equals("Administrator"))
                {
                    rbAdmin.Checked = true;
                }
                else if (getData.User_Type.Equals("Student"))
                {
                    rbStudent.Checked = true;
                }
                else if (getData.User_Type.Equals("Faculty"))
                {
                    rbFaculty.Checked = true;
                }
                else if(getData.User_Type.Equals(null))
                {
                    rbAdmin.Checked = false;
                    rbFaculty.Checked = false;
                    rbStudent.Checked = false;
                }
            }

        }
    }
}
