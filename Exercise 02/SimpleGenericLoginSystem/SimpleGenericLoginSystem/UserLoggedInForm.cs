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

        private User user;

        public UserLoggedInForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void UserLoggedInForm_Load(object sender, EventArgs e)
        {

            helpForm = new HelpForm();
            loginForm = new LoginForm();
            // find all created labels


            // for testing those labels will be setup here and later this will be read from file

            labelFirstName.Text = "First name: " + user.FirstName;
            labelLastName.Text = "Last name: " + user.LastName;
            labelUserID.Text = "User ID: " + user.UserID;
            labelRagisteringUserPassword.Text = "Password: " + user.UserPassword;
            labelAccountNumber.Text = "Account Number: " + user.AccountNumber;
            labelUserEmail.Text = "Email: " + user.Email;
            labelRole.Text = "Role: " + user.UserRole;
    }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
        }        

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpForm.Show();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm(this).Show();
            this.Hide();
        }
    }
}
