using PasswordValidator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Class ChangePasswordForm inherits from Form
/// </summary>
namespace SimpleGenericLoginSystem
{   
    public partial class ChangePasswordForm : Form
    {
        private Form callingForm;

        /// <summary>
        /// Public method that initializes all the values
        /// </summary>
        /// <param name="callingForm"></param>
        public ChangePasswordForm(Form callingForm)
        {
            this.callingForm = callingForm;
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for Cancel button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelPassword_Click(object sender, EventArgs e)
        {
            this.Close();
            callingForm.Show();
        }
        /// <summary>
        /// Event handler for Change password button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (Password.isPassword(textBoxNewPassword.Text))
            {
                //success message
                string message = "Password changed successfully.";
                string caption = "Passweord changed";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);
                textBoxNewPassword.Text = "";
            }
            else
            {
                string message = Password.getLastErrorMessage();
                string caption = "Password validation error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
