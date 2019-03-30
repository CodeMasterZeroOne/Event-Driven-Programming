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
            this.textBoxInputFirstName = new System.Windows.Forms.TextBox();
            this.textBoxInputLastName = new System.Windows.Forms.TextBox();
            this.textBoxInputUserID = new System.Windows.Forms.TextBox();
            this.textBoxInputPassword = new System.Windows.Forms.TextBox();
            this.textBoxInputAccountNumber = new System.Windows.Forms.TextBox();
            this.textBoxInputEmail = new System.Windows.Forms.TextBox();
            this.comboBoxInputRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.buttonRegisterUser = new System.Windows.Forms.Button();
            this.buttonCancelRegistration = new System.Windows.Forms.Button();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(39, 68);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(58, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(39, 94);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last name:";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(39, 120);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(46, 13);
            this.labelUserID.TabIndex = 2;
            this.labelUserID.Text = "User ID:";
            // 
            // labelRagisteringUserPassword
            // 
            this.labelRagisteringUserPassword.AutoSize = true;
            this.labelRagisteringUserPassword.Location = new System.Drawing.Point(39, 146);
            this.labelRagisteringUserPassword.Name = "labelRagisteringUserPassword";
            this.labelRagisteringUserPassword.Size = new System.Drawing.Size(56, 13);
            this.labelRagisteringUserPassword.TabIndex = 3;
            this.labelRagisteringUserPassword.Text = "Password:";
            // 
            // labelAccNumber
            // 
            this.labelAccNumber.AutoSize = true;
            this.labelAccNumber.Location = new System.Drawing.Point(39, 172);
            this.labelAccNumber.Name = "labelAccNumber";
            this.labelAccNumber.Size = new System.Drawing.Size(90, 13);
            this.labelAccNumber.TabIndex = 4;
            this.labelAccNumber.Text = "Account Number:";
            // 
            // labelUserEmail
            // 
            this.labelUserEmail.AutoSize = true;
            this.labelUserEmail.Location = new System.Drawing.Point(39, 198);
            this.labelUserEmail.Name = "labelUserEmail";
            this.labelUserEmail.Size = new System.Drawing.Size(35, 13);
            this.labelUserEmail.TabIndex = 5;
            this.labelUserEmail.Text = "Email:";
            // 
            // textBoxInputFirstName
            // 
            this.textBoxInputFirstName.Location = new System.Drawing.Point(139, 65);
            this.textBoxInputFirstName.MaxLength = 25;
            this.textBoxInputFirstName.Name = "textBoxInputFirstName";
            this.textBoxInputFirstName.Size = new System.Drawing.Size(206, 20);
            this.textBoxInputFirstName.TabIndex = 6;
            // 
            // textBoxInputLastName
            // 
            this.textBoxInputLastName.Location = new System.Drawing.Point(139, 91);
            this.textBoxInputLastName.MaxLength = 25;
            this.textBoxInputLastName.Name = "textBoxInputLastName";
            this.textBoxInputLastName.Size = new System.Drawing.Size(206, 20);
            this.textBoxInputLastName.TabIndex = 7;
            // 
            // textBoxInputUserID
            // 
            this.textBoxInputUserID.Location = new System.Drawing.Point(139, 117);
            this.textBoxInputUserID.MaxLength = 8;
            this.textBoxInputUserID.Name = "textBoxInputUserID";
            this.textBoxInputUserID.Size = new System.Drawing.Size(206, 20);
            this.textBoxInputUserID.TabIndex = 8;
            // 
            // textBoxInputPassword
            // 
            this.textBoxInputPassword.Location = new System.Drawing.Point(139, 143);
            this.textBoxInputPassword.MaxLength = 16;
            this.textBoxInputPassword.Name = "textBoxInputPassword";
            this.textBoxInputPassword.Size = new System.Drawing.Size(206, 20);
            this.textBoxInputPassword.TabIndex = 9;
            // 
            // textBoxInputAccountNumber
            // 
            this.textBoxInputAccountNumber.Location = new System.Drawing.Point(139, 169);
            this.textBoxInputAccountNumber.MaxLength = 9;
            this.textBoxInputAccountNumber.Name = "textBoxInputAccountNumber";
            this.textBoxInputAccountNumber.Size = new System.Drawing.Size(206, 20);
            this.textBoxInputAccountNumber.TabIndex = 10;
            // 
            // textBoxInputEmail
            // 
            this.textBoxInputEmail.Location = new System.Drawing.Point(139, 195);
            this.textBoxInputEmail.MaxLength = 35;
            this.textBoxInputEmail.Name = "textBoxInputEmail";
            this.textBoxInputEmail.Size = new System.Drawing.Size(206, 20);
            this.textBoxInputEmail.TabIndex = 11;
            // 
            // comboBoxInputRole
            // 
            this.comboBoxInputRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInputRole.Items.AddRange(new object[] {
            "Customer",
            "Balance Operator",
            "Account Operator",
            "Auditor",
            "Administrator",
            "Super User",
            "Super User (All Payments)"});
            this.comboBoxInputRole.Location = new System.Drawing.Point(139, 221);
            this.comboBoxInputRole.Name = "comboBoxInputRole";
            this.comboBoxInputRole.Size = new System.Drawing.Size(206, 21);
            this.comboBoxInputRole.TabIndex = 12;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(39, 224);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(32, 13);
            this.labelRole.TabIndex = 13;
            this.labelRole.Text = "Role:";
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
            this.Controls.Add(this.comboBoxInputRole);
            this.Controls.Add(this.textBoxInputEmail);
            this.Controls.Add(this.textBoxInputAccountNumber);
            this.Controls.Add(this.textBoxInputPassword);
            this.Controls.Add(this.textBoxInputUserID);
            this.Controls.Add(this.textBoxInputLastName);
            this.Controls.Add(this.textBoxInputFirstName);
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
        private System.Windows.Forms.TextBox textBoxInputFirstName;
        private System.Windows.Forms.TextBox textBoxInputLastName;
        private System.Windows.Forms.TextBox textBoxInputUserID;
        private System.Windows.Forms.TextBox textBoxInputPassword;
        private System.Windows.Forms.TextBox textBoxInputAccountNumber;
        private System.Windows.Forms.TextBox textBoxInputEmail;
        private System.Windows.Forms.ComboBox comboBoxInputRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button buttonRegisterUser;
        private System.Windows.Forms.Button buttonCancelRegistration;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
    }
}