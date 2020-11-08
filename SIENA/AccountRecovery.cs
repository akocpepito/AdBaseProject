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
                MessageBox.Show("Updated! Your new password is "+newPassword);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
        }

    }
}
