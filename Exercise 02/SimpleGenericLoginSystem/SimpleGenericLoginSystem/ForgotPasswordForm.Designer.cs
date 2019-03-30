namespace SimpleGenericLoginSystem
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelRecoverPassword = new System.Windows.Forms.Label();
            this.labelRecoverEmail = new System.Windows.Forms.Label();
            this.buttonRecoverPassword = new System.Windows.Forms.Button();
            this.buttonCancelRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(147, 122);
            this.textBoxUserID.MaxLength = 8;
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(132, 20);
            this.textBoxUserID.TabIndex = 4;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(88, 125);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(46, 13);
            this.labelUserID.TabIndex = 3;
            this.labelUserID.Text = "User ID:";
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
            // buttonRecoverPassword
            // 
            this.buttonRecoverPassword.Location = new System.Drawing.Point(147, 148);
            this.buttonRecoverPassword.Name = "buttonRecoverPassword";
            this.buttonRecoverPassword.Size = new System.Drawing.Size(132, 23);
            this.buttonRecoverPassword.TabIndex = 7;
            this.buttonRecoverPassword.Text = "Recover Password";
            this.buttonRecoverPassword.UseVisualStyleBackColor = true;
            this.buttonRecoverPassword.Click += new System.EventHandler(this.buttonRecoverPassword_Click);
            // 
            // buttonCancelRegistration
            // 
            this.buttonCancelRegistration.Location = new System.Drawing.Point(12, 326);
            this.buttonCancelRegistration.Name = "buttonCancelRegistration";
            this.buttonCancelRegistration.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelRegistration.TabIndex = 16;
            this.buttonCancelRegistration.Text = "Cancel";
            this.buttonCancelRegistration.UseVisualStyleBackColor = true;
            this.buttonCancelRegistration.Click += new System.EventHandler(this.buttonCancelRegistration_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelRegistration);
            this.Controls.Add(this.buttonRecoverPassword);
            this.Controls.Add(this.labelRecoverEmail);
            this.Controls.Add(this.labelRecoverPassword);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.labelUserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot password window";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelRecoverPassword;
        private System.Windows.Forms.Label labelRecoverEmail;
        private System.Windows.Forms.Button buttonRecoverPassword;
        private System.Windows.Forms.Button buttonCancelRegistration;
    }
}