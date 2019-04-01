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

namespace SimpleGenericLoginSystem
{
    public partial class LoginForm : Form
    {
        private RegisterForm registerForm;
        private HelpForm helpForm;
        private ForgotPasswordForm forgotPasswordForm;
        private UserLoggedInForm userLoggedInForm;

        private DataTable dataTable;

        public LoginForm()
        {
            InitializeComponent();
            //dataTable = FileManager.getFileManager().LoadData();
            //// printing to console
            //foreach (DataRow dataRow in dataTable.Rows)
            //{
            //    foreach (var item in dataRow.ItemArray)
            //    {
            //        Debug.Write(item + " ");
            //    }
            //    Debug.WriteLine("");
            //}
            //Debug.WriteLine(DataManager.getDataManager().doesUserExist("laucon09"));
            //Debug.WriteLine(DataManager.getDataManager().doesUserExist("Dupek"));
            //Debug.WriteLine(DataManager.getDataManager().doesPasswordMatch("laucon09", "notapassword"));
            //Debug.WriteLine(DataManager.getDataManager().doesPasswordMatch("laucon09", "GarnishIsland-09"));
            //Debug.WriteLine(DataManager.getDataManager().doesPasswordMatch("lauco86n09", "GarnishIsland-09"));
            //Tuple<bool, DataRow> myTuple = DataManager.getDataManager().doesPasswordMatch("laucon09", "GarnishIsland-09");
            //Debug.WriteLine(myTuple.Item1);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            helpForm = new HelpForm();
            registerForm = new RegisterForm();
            forgotPasswordForm = new ForgotPasswordForm();
            
        }

        private void buttonUserRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm.Show();
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpForm.Show();
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPasswordForm.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            // validate the user and if validated show successful login window if
            // not show error message incorect password or user Id

            // if userID and password == "fred" 
            // then user is super user
            
            string userID = textBoxUserID.Text;
            string userPassword = textBoxUserPassword.Text;

            Tuple<bool, DataRow> verifiedUser = DataManager.getDataManager().doesPasswordMatch(userID, userPassword);

            if (verifiedUser.Item1)
            {
                userLoggedInForm = new UserLoggedInForm(DataManager.getDataManager().rowToUser(verifiedUser.Item2));
                this.Hide();
                userLoggedInForm.Show();
            }
           
            else
            {
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
    }
}
