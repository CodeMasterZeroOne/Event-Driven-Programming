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
        private RegisterForm registerForm;
        private HelpForm helpForm;
        private LoginForm loginForm;
        private ForgotPasswordForm forgotPasswordForm;

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            loginForm = new LoginForm();
            forgotPasswordForm = this;
    }

        private void buttonCancelRegistration_Click(object sender, EventArgs e)
        {
            forgotPasswordForm.Close();
            loginForm.Show();
        }
    }
}
