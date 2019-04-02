using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// LoginForm class responsible for login to banking system
/// 
/// </summary>
namespace SimpleGenericLoginSystem
{
    public partial class LoginForm : Form
    {
        private RegisterForm registerForm;
        private HelpForm helpForm;
        private ForgotPasswordForm forgotPasswordForm;
        private UserLoggedInForm userLoggedInForm;

        private string userID;
        private string userPassword;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Event handler for register user button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUserRegister_Click(object sender, EventArgs e)
        {
            resetInputFields();
            this.Hide();
            registerForm = new RegisterForm(this);
            registerForm.Show();
        }
        /// <summary>
        /// Event handler for ToolStrip menu item help clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpForm = new HelpForm();
            helpForm.Show();
        }
        /// <summary>
        /// Event handler for ToolStrip menu item File/Exit clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Event handler for forgot password linklabel clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            resetInputFields();
            this.Hide();
            forgotPasswordForm = new ForgotPasswordForm(this);
            forgotPasswordForm.Show();
        }
        /// <summary>
        /// Validate the user and if validated show successful login window if
        /// not show error message incorect password or user Id
        /// If userID and password == "fred" 
        /// then user is super user with all the privileges
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            userID = textBoxUserID.Text;
            userPassword = textBoxUserPassword.Text;

            Tuple<bool, DataRow> verifiedUser = DataManager.getDataManager().doesPasswordMatch(userID, userPassword);

            if (verifiedUser.Item1)
            {
                resetInputFields();
                this.Hide();
                userLoggedInForm = new UserLoggedInForm(this, DataManager.getDataManager().rowToUser(verifiedUser.Item2));
                userLoggedInForm.Show();
            }
            else
            {
                resetInputFields();
                //error msg
                if (String.IsNullOrEmpty(userID) || String.IsNullOrEmpty(userPassword))
                {
                    string message = "Please enter user ID and password.";
                    string caption = "Input error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    string message = "Please enter valid user ID and password.";
                    string caption = "Login error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public void resetInputFields()
        {
            textBoxUserID.Text = "";
            textBoxUserPassword.Text = "";
        }
    }
}
