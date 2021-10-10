using System;
using System.Linq;
using System.Windows.Forms;

namespace GWUserManagement
{
    public partial class frmConfirm : Form
    {
        private string formType;
        private string email;
        private User user;
        public bool completed = false;

        public frmConfirm(string formType, User user = null, string email = null)
        {
            InitializeComponent();

            this.formType = formType;
            this.email = email;
            this.user = user;
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            labelName.Text = user.Name;
            labelEmail.Text = user.Email;
            labelPhone.Text = user.Phone;
            labelPassword.Text = String.Concat(Enumerable.Repeat("*", user.Password.Length));
            labelImage.Text = user.Image;
            labelAdministration.Text = user.IsAdmin ? "Yes" : "No";
            labelGroup.Text = user.Group;

            if (formType == "add")
            {
                labelMessage.Text = "Please confirm the detail of the new user.";
            }
            else if (formType == "edit")
            {
                labelMessage.Text = "Please confirm the new detail of the user.";
            }
            else if (formType == "delete")
            {
                labelMessage.Text = "Are you sure to delete the user below?";
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection("localhost", "usermanagement", "root", "password");
            DBUsers dbUsers = new DBUsers();

            connection.OpenConnection();

            if (formType == "add")
            {
                dbUsers.Insert(connection, this.user);
            }
            else if (formType == "edit")
            {
                dbUsers.Update(connection, this.email, this.user);
            }
            else if (formType == "delete")
            {
                dbUsers.Delete(connection, this.user.Email);
            }
            connection.CloseConnection();
            completed = true;
            this.Close();
        }
    }
}
