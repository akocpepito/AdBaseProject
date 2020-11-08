namespace SIENA
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.sienaDBDataSet = new SIENA.SienaDBDataSet();
            this.sienaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sienaDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnManageCourse = new System.Windows.Forms.Button();
            this.btnCreateCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewUsers = new SIENA.ViewUsers();
            this.homePage1 = new SIENA.HomePage();
            this.create_User1 = new SIENA.Create_User();
            this.modify_User1 = new SIENA.Modify_User();
            ((System.ComponentModel.ISupportInitialize)(this.sienaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sienaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sienaDBDataSetBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sienaDBDataSet
            // 
            this.sienaDBDataSet.DataSetName = "SienaDBDataSet";
            this.sienaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sienaDBDataSetBindingSource
            // 
            this.sienaDBDataSetBindingSource.DataSource = this.sienaDBDataSet;
            this.sienaDBDataSetBindingSource.Position = 0;
            // 
            // sienaDBDataSetBindingSource1
            // 
            this.sienaDBDataSetBindingSource1.DataSource = this.sienaDBDataSet;
            this.sienaDBDataSetBindingSource1.Position = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnViewCourses);
            this.panel2.Controls.Add(this.btnManageCourse);
            this.panel2.Controls.Add(this.btnCreateCourse);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnViewUsers);
            this.panel2.Controls.Add(this.btnManageUser);
            this.panel2.Controls.Add(this.btnCreateUser);
            this.panel2.Controls.Add(this.greetingLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 614);
            this.panel2.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(13, 487);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(137, 35);
            this.btnLogout.TabIndex = 210;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.Location = new System.Drawing.Point(13, 361);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(137, 35);
            this.btnViewCourses.TabIndex = 209;
            this.btnViewCourses.Text = "View Courses";
            this.btnViewCourses.UseVisualStyleBackColor = true;
            // 
            // btnManageCourse
            // 
            this.btnManageCourse.Location = new System.Drawing.Point(13, 324);
            this.btnManageCourse.Name = "btnManageCourse";
            this.btnManageCourse.Size = new System.Drawing.Size(137, 35);
            this.btnManageCourse.TabIndex = 208;
            this.btnManageCourse.Text = "Manage Course";
            this.btnManageCourse.UseVisualStyleBackColor = true;
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.Location = new System.Drawing.Point(13, 288);
            this.btnCreateCourse.Name = "btnCreateCourse";
            this.btnCreateCourse.Size = new System.Drawing.Size(137, 35);
            this.btnCreateCourse.TabIndex = 207;
            this.btnCreateCourse.Text = "Create Course";
            this.btnCreateCourse.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 206;
            this.label3.Text = "Course Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 205;
            this.label1.Text = "User Management";
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Location = new System.Drawing.Point(13, 218);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(137, 35);
            this.btnViewUsers.TabIndex = 204;
            this.btnViewUsers.Text = "View Users";
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Location = new System.Drawing.Point(13, 181);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(137, 35);
            this.btnManageUser.TabIndex = 203;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(13, 145);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(137, 35);
            this.btnCreateUser.TabIndex = 202;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.Location = new System.Drawing.Point(13, 96);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(63, 13);
            this.greetingLabel.TabIndex = 1;
            this.greetingLabel.Text = "Welcome ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // viewUsers
            // 
            this.viewUsers.Location = new System.Drawing.Point(166, 0);
            this.viewUsers.Name = "viewUsers";
            this.viewUsers.Size = new System.Drawing.Size(581, 614);
            this.viewUsers.TabIndex = 205;
            // 
            // homePage1
            // 
            this.homePage1.BackColor = System.Drawing.Color.Gold;
            this.homePage1.Location = new System.Drawing.Point(166, 0);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(581, 614);
            this.homePage1.TabIndex = 204;
            // 
            // create_User1
            // 
            this.create_User1.Location = new System.Drawing.Point(166, 0);
            this.create_User1.Name = "create_User1";
            this.create_User1.Size = new System.Drawing.Size(581, 614);
            this.create_User1.TabIndex = 202;
            // 
            // modify_User1
            // 
            this.modify_User1.Location = new System.Drawing.Point(166, 0);
            this.modify_User1.Name = "modify_User1";
            this.modify_User1.Size = new System.Drawing.Size(581, 621);
            this.modify_User1.TabIndex = 203;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 610);
            this.Controls.Add(this.viewUsers);
            this.Controls.Add(this.homePage1);
            this.Controls.Add(this.create_User1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.modify_User1);
            this.Name = "AdminPanel";
            this.Text = "Administrator Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sienaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sienaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sienaDBDataSetBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sienaDBDataSetBindingSource;
        private SienaDBDataSet sienaDBDataSet;
        private System.Windows.Forms.BindingSource sienaDBDataSetBindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnManageCourse;
        private System.Windows.Forms.Button btnCreateCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Create_User create_User1;
        private Modify_User modify_User1;
        private HomePage homePage1;
        private ViewUsers viewUsers;
        private System.Windows.Forms.Button btnLogout;
    }
}