using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GWUserManagement
{
    public partial class frmHome : Form
    {
        DBConnection connection = null;

        public List<User> users = null;

        public User loggedInUser = null;
        User selectedUser = null;

        public frmHome()
        {
            InitializeComponent();

            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
            buttonEdit.Enabled = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.connection = new DBConnection("localhost", "usermanagement", "root", "Maiko119922");
            DBUsers dbUsers = new DBUsers();

            this.connection.OpenConnection();

            this.users = dbUsers.GetUsers(this.connection);

            Form loginForm = new frmLogin(this, this.users);
            loginForm.ShowDialog();

            if (loggedInUser != null)
            {
                displayUsers();
                listBoxUsers.SelectedItem = loggedInUser;
            }
            else
                this.Close();
        }

        public void displayUsers()
        {
            listBoxUsers.Items.Clear();

            foreach (User user in this.users)
            {
                listBoxUsers.Items.Add(user);
            }
            listBoxUsers.DisplayMember = "Name";

            if (loggedInUser.IsAdmin)
                buttonAdd.Enabled = true;

            labelLoggedInName.Text = $"Hello, {loggedInUser.Name}({loggedInUser.Email})";
        }

        private void listBoxUsers_Select(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
            {
                selectedUser = listBoxUsers.SelectedItem as User;

                textBoxName.Text = selectedUser.Name;
                textBoxEmailAddress.Text = selectedUser.Email;
                textBoxPhoneNumber.Text = selectedUser.Phone;
                checkBoxAdministration.Checked = selectedUser.IsAdmin;
                textBoxGroup.Text = selectedUser.Group;
                pictureBoxImage.ImageLocation = selectedUser.Image;

                if (loggedInUser.IsAdmin)
                {
                    buttonDelete.Enabled = true;
                    buttonEdit.Enabled = true;
                }
                else if (selectedUser == loggedInUser)
                    buttonEdit.Enabled = true;

                else if (selectedUser != loggedInUser)
                    buttonEdit.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string type = "edit";

            frmEdit editForm = new frmEdit(this, selectedUser, users, type);
            editForm.ShowDialog();

            listBoxUsers.SelectedItem = editForm.newUser;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
