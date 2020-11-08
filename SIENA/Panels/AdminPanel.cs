using SIENA.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIENA
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPanel registerPanel = new RegisterPanel();
            registerPanel.Show();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            create_User1.Visible = true;
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            create_User1.Visible = false;
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            create_User1.Visible = false;
        }
    }
}
