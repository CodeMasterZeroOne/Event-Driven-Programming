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
        private Form callingForm;
        private HelpForm helpForm;

        private ComboBox defaultRole;
        /// <summary>
        /// Public method for initialization of the values.
        /// </summary>
        /// <param name="callingForm"></param>
        public RegisterForm(Form callingForm)
        {
            this.callingForm = callingForm;
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            defaultRole = Controls.Find("comboBoxInputRole", true).FirstOrDefault() as ComboBox;
            defaultRole.SelectedIndex = 0; // index 0 is "Customer" default value
        }

        private void buttonCancelRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
            callingForm.Show();
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpForm = new HelpForm();
            helpForm.Show();
        }

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxInputFirstName.Text) ||
                String.IsNullOrEmpty(textBoxInputLastName.Text) ||
                String.IsNullOrEmpty(textBoxInputUserID.Text) ||
                String.IsNullOrEmpty(textBoxInputPassword.Text) ||
                String.IsNullOrEmpty(textBoxInputEmail.Text))
            {
                string message = "Fields required are:\nFirst Name:\nLast Name:\nUser ID:\nPassword:\nEmail:\n";
                string caption = "New User";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);
            }
            else
            {
                string message = "New user registered successfully.";
                string caption = "New User";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Asterisk);
                callingForm.Show();
            }
        }
    }
}
