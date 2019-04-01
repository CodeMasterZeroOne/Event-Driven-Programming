namespace SimpleGenericLoginSystem
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelRecoverPassword = new System.Windows.Forms.Label();
            this.labelRecoverEmail = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonCancelRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserID
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(147, 122);
            this.textBoxNewPassword.MaxLength = 8;
            this.textBoxNewPassword.Name = "textBoxUserID";
            this.textBoxNewPassword.Size = new System.Drawing.Size(132, 20);
            this.textBoxNewPassword.TabIndex = 4;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(67, 125);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(80, 13);
            this.labelNewPassword.TabIndex = 3;
            this.labelNewPassword.Text = "New password:";
            // 
            // labelRecoverPassword
            // 
            this.labelRecoverPassword.AutoSize = true;
            this.labelRecoverPassword.ForeColor = System.Drawing.Color.Red;
            this.labelRecoverPassword.Location = new System.Drawing.Point(119, 224);
            this.labelRecoverPassword.Name = "labelRecoverPassword";
            this.labelRecoverPassword.Size = new System.Drawing.Size(0, 13);
            this.labelRecoverPassword.TabIndex = 5;
            // 
            // labelRecoverEmail
            // 
            this.labelRecoverEmail.AccessibleName = "";
            this.labelRecoverEmail.AutoSize = true;
            this.labelRecoverEmail.ForeColor = System.Drawing.Color.Red;
            this.labelRecoverEmail.Location = new System.Drawing.Point(119, 201);
            this.labelRecoverEmail.Name = "labelRecoverEmail";
            this.labelRecoverEmail.Size = new System.Drawing.Size(0, 13);
            this.labelRecoverEmail.TabIndex = 6;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(147, 148);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(132, 23);
            this.buttonChangePassword.TabIndex = 7;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonCancelRegistration
            // 
            this.buttonCancelRegistration.Location = new System.Drawing.Point(12, 326);
            this.buttonCancelRegistration.Name = "buttonCancelRegistration";
            this.buttonCancelRegistration.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelRegistration.TabIndex = 16;
            this.buttonCancelRegistration.Text = "Cancel";
            this.buttonCancelRegistration.UseVisualStyleBackColor = true;
            this.buttonCancelRegistration.Click += new System.EventHandler(this.buttonCancelPassword_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelRegistration);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.labelRecoverEmail);
            this.Controls.Add(this.labelRecoverPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.labelNewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change password window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelRecoverPassword;
        private System.Windows.Forms.Label labelRecoverEmail;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonCancelRegistration;
    }
}