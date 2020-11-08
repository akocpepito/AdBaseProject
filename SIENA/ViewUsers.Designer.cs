namespace SIENA
{
    partial class ViewUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userDataTable = new System.Windows.Forms.DataGridView();
            this.addUser = new System.Windows.Forms.Label();
            this.linkRefresh = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.userDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userDataTable
            // 
            this.userDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataTable.Location = new System.Drawing.Point(14, 74);
            this.userDataTable.Name = "userDataTable";
            this.userDataTable.Size = new System.Drawing.Size(556, 509);
            this.userDataTable.TabIndex = 1;
            this.userDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataTable_CellContentClick);
            // 
            // addUser
            // 
            this.addUser.AutoSize = true;
            this.addUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.Location = new System.Drawing.Point(16, 21);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(157, 37);
            this.addUser.TabIndex = 2;
            this.addUser.Text = "View Users";
            // 
            // linkRefresh
            // 
            this.linkRefresh.AutoSize = true;
            this.linkRefresh.Location = new System.Drawing.Point(500, 45);
            this.linkRefresh.Name = "linkRefresh";
            this.linkRefresh.Size = new System.Drawing.Size(70, 13);
            this.linkRefresh.TabIndex = 3;
            this.linkRefresh.TabStop = true;
            this.linkRefresh.Text = "Refresh View";
            this.linkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRefresh_LinkClicked);
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkRefresh);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.userDataTable);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(584, 622);
            this.Load += new System.EventHandler(this.ViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView userDataTable;
        private System.Windows.Forms.Label addUser;
        private System.Windows.Forms.LinkLabel linkRefresh;
    }
}
