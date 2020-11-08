using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIENA
{
    public partial class Create_User : UserControl
    {
        public Create_User()
        {
            InitializeComponent();
        }

        private void Create_User_Load(object sender, EventArgs e)
        {
            cbCourse.Items.Add("BS in Computer Science");
            cbCourse.Items.Add("BS in Computer Engineering");
            cbCourse.Items.Add("BS in Tourism Management");
            cbCourse.Items.Add("BS in Hospitality Management");
            cbCourse.Items.Add("BS in Information Technology");
            cbCourse.Items.Add("BA in Communication");
            cbCourse.Items.Add("BS in Business Administration");
            cbCourse.Items.Add("BS in Culinary Management");

            dtpBirthDate.Value = new DateTime(2000, 01, 01);
            dtpJoined.Value = new DateTime(2000, 01, 01);

            cbDept.Items.Add("Information & Communications Technology");
            cbDept.Items.Add("Business & Management");
            cbDept.Items.Add("Hospitality Management");
            cbDept.Items.Add("Tourism Management");
            cbDept.Items.Add("Engineering");
            cbDept.Items.Add("Arts & Sciences");
        }

        private void clearForm()
        {
            txtEmail.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtMname.Text = "";
            txtMobile.Text = "";
            txtPwd.Text = "";
            txtUname.Text = "";
            rtbAddress.Text = "";
            dtpBirthDate.Value = new DateTime(2000,01,01);
            dtpJoined.Value = new DateTime(2000,01,01);
            rbAdmin.Checked = false;
            rbFaculty.Checked = false;
            rbFemale.Checked = false;
            rbMale.Checked = false;
            rbStudent.Checked = false;
            cbCourse.Items.Clear();
            cbDept.Items.Clear();
            checkEnabled.Checked = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.First_Name = txtFname.Text;
            newUser.Last_Name = txtLname.Text;
            newUser.Middle_Name = txtMname.Text;
            newUser.Email_address = txtEmail.Text;
            newUser.Username = txtUname.Text;
            newUser.Password = txtPwd.Text;
            newUser.User_Type = groupUser.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            newUser.BirthDate = dtpBirthDate.Value;
            newUser.Year_Joined = dtpJoined.Value;
            newUser.Address = rtbAddress.Text;
            newUser.Gender = groupUser.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            newUser.Course = cbCourse.Text;
            newUser.Department = cbDept.Text;

            if (checkEnabled.Checked)
            {
                newUser.Enabled = "Yes";
            }
            else
            {
                newUser.Enabled = "No";
            }
            
            DataClassDataContext newUserDbCtx = new DataClassDataContext();
            newUserDbCtx.Users.InsertOnSubmit(newUser);

            try
            {
                newUserDbCtx.SubmitChanges();
                //sendEmailConfirmation(newUser);
                MessageBox.Show("The account has been created.");
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
