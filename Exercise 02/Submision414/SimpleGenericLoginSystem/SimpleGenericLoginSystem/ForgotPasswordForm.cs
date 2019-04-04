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
    /// Class ForgotPasswordForm inherits from Form
    /// </summary>
    public partial class ForgotPasswordForm : Form
    {
        private Form callingForm;
        private HelpForm helpForm;
        /// <summary>
        /// Public method 
        /// </summary>
        /// <param name="callingForm"></param>
        public ForgotPasswordForm(Form callingForm)
        {
            this.callingForm = callingForm;
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            
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
        /// <summary>
        /// Event handler for Cancel registration button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
            callingForm.Show();
        }
        /// <summary>
        /// Validate user ID and if it exist
        /// display user email and password associated with this email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecoverPassword_Click(object sender, EventArgs e)
        {
            string userID = textBoxUserID.Text;

            Tuple<bool, DataRow> verifiedUser = DataManager.getDataManager().doesUserIdMatch(userID);

            if (verifiedUser.Item1)
            {
                User user = DataManager.getDataManager().rowToUser(verifiedUser.Item2);
                labelRecoverEmail.Text = "Email sent to: " + user.Email;
                labelRecoverPassword.Text = "Dear "+ user.FirstName + ",\nPassword recovery was successful.";
            }
            else
            {
                // error msg
                if (String.IsNullOrEmpty(userID))
                {
                    string message = "Please enter user ID to recover password.";
                    string caption = "Input error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    string message = "Please enter valid user ID.";
                    string caption = "Validation error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
            }
        }
    }
}
