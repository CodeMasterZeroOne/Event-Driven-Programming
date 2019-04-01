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

namespace SimpleGenericLoginSystem
{
    public partial class ChangePasswordForm : Form
    {
        private Form callingForm;

        public ChangePasswordForm(Form callingForm)
        {
            this.callingForm = callingForm;
            InitializeComponent();
        }

        private void buttonCancelPassword_Click(object sender, EventArgs e)
        {
            this.Close();
            callingForm.Show();
        }

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
    }
}
