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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUsers));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addUser = new System.Windows.Forms.Label();
            this.btnSearchBox = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 463);
            this.dataGridView1.TabIndex = 1;
            // 
            // addUser
            // 
            this.addUser.AutoSize = true;
            this.addUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.Location = new System.Drawing.Point(16, 21);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(167, 37);
            this.addUser.TabIndex = 2;
            this.addUser.Text = "Search User";
            // 
            // btnSearchBox
            // 
            this.btnSearchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchBox.BackgroundImage")));
            this.btnSearchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchBox.Location = new System.Drawing.Point(708, 34);
            this.btnSearchBox.Name = "btnSearchBox";
            this.btnSearchBox.Size = new System.Drawing.Size(25, 25);
            this.btnSearchBox.TabIndex = 83;
            this.btnSearchBox.UseVisualStyleBackColor = true;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(375, 37);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(334, 20);
            this.txtSearchBox.TabIndex = 82;
            this.txtSearchBox.Text = "Search account";
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchBox);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(777, 540);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label addUser;
        private System.Windows.Forms.Button btnSearchBox;
        private System.Windows.Forms.TextBox txtSearchBox;
    }
}
