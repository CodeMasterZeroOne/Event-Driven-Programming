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
        private ForgotPasswordForm forgotPasswordForm;
        private Label labelEmail;
        private Label labelPassword;
        private String email = "pawel@whatever.home";
        private String password = "Dorian19";

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            forgotPasswordForm = this;
            loginForm = new LoginForm();
            labelEmail = Controls.Find("labelRecoverEmail", true).FirstOrDefault() as Label;
            labelPassword = Controls.Find("labelRecoverPassword", true).FirstOrDefault() as Label;
        }

        private void buttonCancelRegistration_Click(object sender, EventArgs e)
        {
            forgotPasswordForm.Close();
            loginForm.Show();
        }

        private void buttonRecoverPassword_Click(object sender, EventArgs e)
        {
            // validate user ID and if it exist
            // display user email and password associated with this email
            labelEmail.Text = "Email sent to: " + email;
            labelPassword.Text = "Recovered password: " + password;
        }
    }
}
