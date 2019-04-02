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
    /// <summary>
    /// Class UserLoggedInForm inherits from Form
    /// </summary>
    public partial class UserLoggedInForm : Form
    {
        private Form callingForm;
        private HelpForm helpForm;

        private User user;

        public UserLoggedInForm(Form callingForm, User user)
        {
            this.callingForm = callingForm;
            this.user = user;
            InitializeComponent();
        }
        /// <summary>
        /// Private method to initialize the values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserLoggedInForm_Load(object sender, EventArgs e)
        {
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
            this.Close();
            callingForm.Show();
        }        

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpForm = new HelpForm();
            helpForm.Show();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePasswordForm(this).Show();
        }
    }
}
