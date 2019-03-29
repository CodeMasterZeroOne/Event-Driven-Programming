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
        }

        private void buttonUserRegister_Click(object sender, EventArgs e)
        {
            loginForm.Hide();
            registerForm.Show();
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpForm = new HelpForm();
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
    }
}
