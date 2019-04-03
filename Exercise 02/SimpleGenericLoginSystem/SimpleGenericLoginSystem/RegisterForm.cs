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
    public partial class RegisterForm : Form
    {
        private Form callingForm;
        private HelpForm helpForm;
        private User user;

        /// <summary>
        /// Public method for initialization of the values.
        /// </summary>
        /// <param name="callingForm"></param>
        public RegisterForm(Form callingForm)
        {
            this.callingForm = callingForm;
            this.user = new User();
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            comboBoxInputRole.SelectedIndex = 0;
        }

        private void buttonCancelRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
            callingForm.Show();
        }

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxInputFirstName.Text) ||
                String.IsNullOrEmpty(textBoxInputLastName.Text) ||
                String.IsNullOrEmpty(textBoxInputUserID.Text) ||
                String.IsNullOrEmpty(textBoxInputPassword.Text) ||
                String.IsNullOrEmpty(textBoxInputEmail.Text))
            {
                string message = "Fields required are:\nFirst Name:\nLast Name:\nUser ID:\nPassword:\nEmail:\n";
                string caption = "New User";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);
            }
            else
            {
                string message = "New user registered successfully.";
                string caption = "New User";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Asterisk);
                callingForm.Show();
            }
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

        private void comboBoxInputRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.setUsersRole(comboBoxInputRole.SelectedIndex);
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
    }
}
