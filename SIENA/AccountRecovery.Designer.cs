namespace SIENA
{
    partial class AccountRecovery
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
            this.txtForgotUname = new System.Windows.Forms.TextBox();
            this.btnForgotSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtForgotUname
            // 
            this.txtForgotUname.Location = new System.Drawing.Point(82, 52);
            this.txtForgotUname.Name = "txtForgotUname";
            this.txtForgotUname.Size = new System.Drawing.Size(100, 20);
            this.txtForgotUname.TabIndex = 0;
            // 
            // btnForgotSubmit
            // 
            this.btnForgotSubmit.Location = new System.Drawing.Point(73, 78);
            this.btnForgotSubmit.Name = "btnForgotSubmit";
            this.btnForgotSubmit.Size = new System.Drawing.Size(122, 23);
            this.btnForgotSubmit.TabIndex = 1;
            this.btnForgotSubmit.Text = "Recover Account";
            this.btnForgotSubmit.UseVisualStyleBackColor = true;
            this.btnForgotSubmit.Click += new System.EventHandler(this.btnForgotSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter your username to recover password";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(178, 164);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Login";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AccountRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 199);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForgotSubmit);
            this.Controls.Add(this.txtForgotUname);
            this.Name = "AccountRecovery";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.AccountRecovery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtForgotUname;
        private System.Windows.Forms.Button btnForgotSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}