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
        /// <summary>
        /// Initialize component
        /// </summary>
        /// <param name="callingForm"></param>
        /// <param name="user"></param>
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

            user.setUsersRole(user.UserRole);
            labelUserPrivilages.Text = "User privilages: " +
                "\nView Account Information: " + user.ViewAccountInformation +
                "      View Account Balances:             " + user.ViewAccountBalances +
                "\nManage Account:              " + user.ManageAccount +
                "      Authorise Account Payments:      " + user.AuthoriseAccountPayments +
                "\nInput Account Payments:   " + user.InputAccountPayments +
                "      View Audit Records:                    " + user.ViewAuditRecords +
                "\nGenerate Audit Records:    " + user.GenerateAuditRecords +
                "      Administration Report Privileges:  " + user.AdministrationReportPrivileges +
                "\nAdministration Full Access:  " + user.AdministrationFullAccess;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            callingForm.Show();
        }        

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePasswordForm(this).Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
