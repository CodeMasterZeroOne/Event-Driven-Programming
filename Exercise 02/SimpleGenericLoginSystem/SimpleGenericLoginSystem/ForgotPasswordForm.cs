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
    public partial class ForgotPasswordForm : Form
    {
        private LoginForm loginForm;

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            loginForm = new LoginForm();
        }

        private void buttonCancelRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void buttonRecoverPassword_Click(object sender, EventArgs e)
        {
            // validate user ID and if it exist
            // display user email and password associated with this email

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
                //error msg
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
