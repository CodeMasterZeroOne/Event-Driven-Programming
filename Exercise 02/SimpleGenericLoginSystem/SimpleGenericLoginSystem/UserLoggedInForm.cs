using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGenericLoginSystem
{
    public partial class UserLoggedInForm : Form
    {
        private LoginForm loginForm;
        private HelpForm helpForm;
        private UserLoggedInForm userLoggedInForm;
        private Label userName;
        private Label userLastName;
        private Label userID;
        private Label userPassword;
        private Label userAccountNumber;
        private Label userEmail;
        private Label userRole;

        public UserLoggedInForm()
        {
            InitializeComponent();
        }

        private void UserLoggedInForm_Load(object sender, EventArgs e)
        {
            userLoggedInForm = this;
            helpForm = new HelpForm();
            loginForm = new LoginForm();
            // find all created labels
            userName = Controls.Find("labelFirstName", true).FirstOrDefault() as Label;
            userLastName = Controls.Find("labelLastName", true).FirstOrDefault() as Label;
            userID = Controls.Find("labelUserID", true).FirstOrDefault() as Label;
            userPassword = Controls.Find("labelRagisteringUserPassword", true).FirstOrDefault() as Label;
            userAccountNumber = Controls.Find("labelAccountNumber", true).FirstOrDefault() as Label;
            userEmail = Controls.Find("labelUserEmail", true).FirstOrDefault() as Label;
            userRole = Controls.Find("labelRole", true).FirstOrDefault() as Label;

            // for testing those labels will be setup here and later this will be read from file
            userName.Text = "First name: ";
            userLastName.Text = "Last name: ";
            userID.Text = "User ID: ";
            userPassword.Text = "Password: ";
            userAccountNumber.Text = "Account Number: ";
            userEmail.Text = "Email: ";
            userRole.Text = "Role: ";
    }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            userLoggedInForm.Hide();
            loginForm.Show();
        }        

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpForm.Show();
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            // Update user details stub method
        }
    }
}
