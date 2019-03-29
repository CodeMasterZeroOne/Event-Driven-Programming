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
        private RegisterForm registerForm;
        private HelpForm helpForm;
        private LoginForm loginForm;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            loginForm = new LoginForm();
            helpForm = new HelpForm();
            registerForm = this;
        }

        private void buttonCancelRegistration_Click(object sender, EventArgs e)
        {
            registerForm.Hide();
            loginForm.Show();
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
