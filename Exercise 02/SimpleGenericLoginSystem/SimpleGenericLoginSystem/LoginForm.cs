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
    public partial class LoginForm : Form
    {
        private RegisterForm registerForm;
        private HelpForm helpForm;
        private LoginForm loginForm;
        private ForgotPasswordForm forgotPasswordForm;
        private UserLoggedInForm userLoggedInForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginForm = this;
            helpForm = new HelpForm();
            registerForm = new RegisterForm();
            forgotPasswordForm = new ForgotPasswordForm();
            userLoggedInForm = new UserLoggedInForm();
        }

        private void buttonUserRegister_Click(object sender, EventArgs e)
        {
            loginForm.Hide();
            registerForm.Show();
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpForm.Show();
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPasswordForm.Show();
            loginForm.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            // validate the user and if validated show successful login window if
            // not show error message incorect password or user Id
            loginForm.Hide();
            userLoggedInForm.Show();
        }
    }
}
