namespace SimpleGenericLoginSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelRagisteringUserPassword = new System.Windows.Forms.Label();
            this.labelAccNumber = new System.Windows.Forms.Label();
            this.labelUserEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.buttonRegisterUser = new System.Windows.Forms.Button();
            this.buttonCancelRegistration = new System.Windows.Forms.Button();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(46, 57);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(58, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(46, 83);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last name:";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(46, 109);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(46, 13);
            this.labelUserID.TabIndex = 2;
            this.labelUserID.Text = "User ID:";
            // 
            // labelRagisteringUserPassword
            // 
            this.labelRagisteringUserPassword.AutoSize = true;
            this.labelRagisteringUserPassword.Location = new System.Drawing.Point(46, 135);
            this.labelRagisteringUserPassword.Name = "labelRagisteringUserPassword";
            this.labelRagisteringUserPassword.Size = new System.Drawing.Size(56, 13);
            this.labelRagisteringUserPassword.TabIndex = 3;
            this.labelRagisteringUserPassword.Text = "Password:";
            // 
            // labelAccNumber
            // 
            this.labelAccNumber.AutoSize = true;
            this.labelAccNumber.Location = new System.Drawing.Point(46, 161);
            this.labelAccNumber.Name = "labelAccNumber";
            this.labelAccNumber.Size = new System.Drawing.Size(90, 13);
            this.labelAccNumber.TabIndex = 4;
            this.labelAccNumber.Text = "Account Number:";
            // 
            // labelUserEmail
            // 
            this.labelUserEmail.AutoSize = true;
            this.labelUserEmail.Location = new System.Drawing.Point(46, 187);
            this.labelUserEmail.Name = "labelUserEmail";
            this.labelUserEmail.Size = new System.Drawing.Size(35, 13);
            this.labelUserEmail.TabIndex = 5;
            this.labelUserEmail.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(146, 132);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(146, 158);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(157, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(146, 184);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(157, 20);
            this.textBox6.TabIndex = 11;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Super User (All Payments)",
            "Super User",
            "Administrator",
            "Auditor",
            "Account Operator",
            "Balance Operator",
            "Customer"});
            this.comboBoxRole.Location = new System.Drawing.Point(146, 210);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(157, 21);
            this.comboBoxRole.TabIndex = 12;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(46, 213);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 13;
            this.labelRole.Text = "Role";
            // 
            // buttonRegisterUser
            // 
            this.buttonRegisterUser.Location = new System.Drawing.Point(297, 326);
            this.buttonRegisterUser.Name = "buttonRegisterUser";
            this.buttonRegisterUser.Size = new System.Drawing.Size(75, 23);
            this.buttonRegisterUser.TabIndex = 14;
            this.buttonRegisterUser.Text = "Register";
            this.buttonRegisterUser.UseVisualStyleBackColor = true;
            // 
            // buttonCancelRegistration
            // 
            this.buttonCancelRegistration.Location = new System.Drawing.Point(13, 325);
            this.buttonCancelRegistration.Name = "buttonCancelRegistration";
            this.buttonCancelRegistration.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelRegistration.TabIndex = 15;
            this.buttonCancelRegistration.Text = "Cancel";
            this.buttonCancelRegistration.UseVisualStyleBackColor = true;
            this.buttonCancelRegistration.Click += new System.EventHandler(this.buttonCancelRegistration_Click);
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Location = new System.Drawing.Point(10, 9);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(35, 13);
            this.linkLabelHelp.TabIndex = 16;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "Help?";
            this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabelHelp);
            this.Controls.Add(this.buttonCancelRegistration);
            this.Controls.Add(this.buttonRegisterUser);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelUserEmail);
            this.Controls.Add(this.labelAccNumber);
            this.Controls.Add(this.labelRagisteringUserPassword);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Window";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelRagisteringUserPassword;
        private System.Windows.Forms.Label labelAccNumber;
        private System.Windows.Forms.Label labelUserEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button buttonRegisterUser;
        private System.Windows.Forms.Button buttonCancelRegistration;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
    }
}