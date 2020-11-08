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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sienaDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.create_User1 = new SIENA.Create_User();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnManageCourse = new System.Windows.Forms.Button();
            this.btnCreateCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sienaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sienaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.sienaDBDataSetBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(277, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // sienaDBDataSetBindingSource1
            // 
            this.sienaDBDataSetBindingSource1.DataSource = this.sienaDBDataSet;
            this.sienaDBDataSetBindingSource1.Position = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
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
            this.panel2.Size = new System.Drawing.Size(167, 614);
            this.panel2.TabIndex = 3;
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Location = new System.Drawing.Point(13, 208);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(137, 35);
            this.btnViewUsers.TabIndex = 204;
            this.btnViewUsers.Text = "View Users";
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Location = new System.Drawing.Point(13, 176);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(220, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Administrator";
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.buttonCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAccount.FlatAppearance.BorderSize = 0;
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.White;
            this.buttonCreateAccount.Location = new System.Drawing.Point(408, 253);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(179, 47);
            this.buttonCreateAccount.TabIndex = 6;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstname.Location = new System.Drawing.Point(457, 84);
            this.textBoxFirstname.Multiline = true;
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(331, 34);
            this.textBoxFirstname.TabIndex = 201;
            this.textBoxFirstname.Text = "Search";
            // 
            // create_User1
            // 
            this.create_User1.Location = new System.Drawing.Point(157, 0);
            this.create_User1.Name = "add_User1";
            this.create_User1.Size = new System.Drawing.Size(347, 614);
            this.create_User1.TabIndex = 202;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 206;
            this.label3.Text = "Course Management";
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.Location = new System.Drawing.Point(13, 351);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(137, 35);
            this.btnViewCourses.TabIndex = 209;
            this.btnViewCourses.Text = "View Courses";
            this.btnViewCourses.UseVisualStyleBackColor = true;
            // 
            // btnManageCourse
            // 
            this.btnManageCourse.Location = new System.Drawing.Point(13, 319);
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
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 610);
            this.Controls.Add(this.create_User1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminPanel";
            this.Text = "Administrator Panel";
            ((System.ComponentModel.ISupportInitialize)(this.sienaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sienaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sienaDBDataSetBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sienaDBDataSetBindingSource;
        private SienaDBDataSet sienaDBDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sienaDBDataSetBindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnCreateUser;
        private Create_User create_User1;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnManageCourse;
        private System.Windows.Forms.Button btnCreateCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}