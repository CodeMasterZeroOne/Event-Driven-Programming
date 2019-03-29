namespace SimpleGenericLoginSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.buttonUserLogin = new System.Windows.Forms.Button();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.labelNewUser = new System.Windows.Forms.Label();
            this.buttonUserRegister = new System.Windows.Forms.Button();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(86, 120);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(46, 13);
            this.labelUserID.TabIndex = 0;
            this.labelUserID.Text = "User ID:";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(87, 151);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(56, 13);
            this.labelUserPassword.TabIndex = 1;
            this.labelUserPassword.Text = "Password:";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(145, 117);
            this.textBoxUserID.MaxLength = 8;
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(132, 20);
            this.textBoxUserID.TabIndex = 2;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(145, 148);
            this.textBoxUserPassword.MaxLength = 16;
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(132, 20);
            this.textBoxUserPassword.TabIndex = 3;
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.Location = new System.Drawing.Point(174, 174);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonUserLogin.TabIndex = 4;
            this.buttonUserLogin.Text = "Login";
            this.buttonUserLogin.UseVisualStyleBackColor = true;
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(171, 200);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(91, 13);
            this.linkLabelForgotPassword.TabIndex = 5;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Forgot password?";
            this.linkLabelForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgotPassword_LinkClicked);
            // 
            // labelNewUser
            // 
            this.labelNewUser.AutoSize = true;
            this.labelNewUser.Location = new System.Drawing.Point(174, 310);
            this.labelNewUser.Name = "labelNewUser";
            this.labelNewUser.Size = new System.Drawing.Size(79, 13);
            this.labelNewUser.TabIndex = 6;
            this.labelNewUser.Text = "Not a member?";
            // 
            // buttonUserRegister
            // 
            this.buttonUserRegister.Location = new System.Drawing.Point(174, 326);
            this.buttonUserRegister.Name = "buttonUserRegister";
            this.buttonUserRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonUserRegister.TabIndex = 7;
            this.buttonUserRegister.Text = "Register";
            this.buttonUserRegister.UseVisualStyleBackColor = true;
            this.buttonUserRegister.Click += new System.EventHandler(this.buttonUserRegister_Click);
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Location = new System.Drawing.Point(12, 9);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(35, 13);
            this.linkLabelHelp.TabIndex = 9;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "Help?";
            this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
            // 
            // buttonExit
            // 
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(336, 9);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(36, 36);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // LoginForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.linkLabelHelp);
            this.Controls.Add(this.buttonUserRegister);
            this.Controls.Add(this.labelNewUser);
            this.Controls.Add(this.linkLabelForgotPassword);
            this.Controls.Add(this.buttonUserLogin);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Window";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Button buttonUserLogin;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.Label labelNewUser;
        private System.Windows.Forms.Button buttonUserRegister;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
        private System.Windows.Forms.Button buttonExit;
    }
}

