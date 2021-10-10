using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Web;

namespace GWUserManagement
{
    public partial class frmLogin : Form
    {
        List<User> users = null;
        frmHome home = null;

        public frmLogin(frmHome home, List<User> usrs)
        {
            InitializeComponent();

            this.users = usrs;
            this.home = home;
            textBoxPassword.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e) { }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User targetUser = null;
            string email = null;

            if (this.textBoxEmailAddress.Text.Length == 0 || this.textBoxPassword.Text.Length == 0)
            {
                this.labelErrorMessage.Text = "Email Address or Password is empty. Please fill both forms.";
                return;
            }

            email = HttpUtility.HtmlEncode(textBoxEmailAddress.Text);

            targetUser = this.getUserByEmail(email);

            if (targetUser == null)
            {
                this.labelErrorMessage.Text = "Cannot find the user. Please try with different email address.";
                return;
            }

            string pwd = this.textBoxPassword.Text;
            bool pwdIsValid = targetUser.Password == pwd ? true : false;

            if (!pwdIsValid)
            {
                this.labelErrorMessage.Text = "Password is invalid. Please try again.";
                return;
            }
            else
            {
                home.loggedInUser = targetUser;
                this.Close();
            }
        }


        private User getUserByEmail(string email)
        {
            foreach (User user in this.users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}