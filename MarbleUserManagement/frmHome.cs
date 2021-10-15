using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GWUserManagement
{
    public partial class frmHome : Form
    {
        public List<User> users = null;

        public User loggedInUser = null;
        User selectedUser = null;

        public frmHome()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection("localhost", "usermanagement", "root", "password");
            DBUsers dbUsers = new DBUsers();

            connection.OpenConnection();
            this.users = dbUsers.GetUsers(connection);
            connection.CloseConnection();

            Form loginForm = new frmLogin(this, this.users);
            loginForm.ShowDialog();

            if (loggedInUser != null)
            {
                displayUsers();
                listBoxUsers.SelectedItem = loggedInUser;
            }
            else
            {
                // Without this, the user would be able to see the blank home dialog without login. 
                this.Close();
            }
        }

        public void displayUsers()
        {
            listBoxUsers.Items.Clear();

            foreach (User user in this.users)
            {
                listBoxUsers.Items.Add(user);
            }
            listBoxUsers.DisplayMember = "Name";

            if (!loggedInUser.IsAdmin)
                buttonAdd.Enabled = false;

            labelLoggedInName.Text = $"Hello, {loggedInUser.Name} ({loggedInUser.Email})";
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
                else if (selectedUser != loggedInUser)
                    buttonEdit.Enabled = false;

                if (selectedUser == loggedInUser)
                {
                    buttonEdit.Enabled = true;
                    buttonDelete.Enabled = false;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedUser == loggedInUser)
            {
                MessageBox.Show("You cannot delete logged in user.");
                return;
            }

            frmConfirm confirmForm = new frmConfirm("delete", selectedUser);
            confirmForm.ShowDialog();

            if (confirmForm.completed == true)
            {
                users.RemoveAll(user => user.Email == selectedUser.Email);
                users = users.OrderBy(user => user.Email).ToList();

                displayUsers();
                listBoxUsers.SelectedItem = loggedInUser;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            bool editingLoggedInUser = loggedInUser == selectedUser ? true : false;
            string currentUserEmail = selectedUser.Email;

            frmEdit editForm = new frmEdit(selectedUser, users, loggedInUser.IsAdmin);

            editForm.ShowDialog();

            if (editForm.editCompleted == true)
            {
                users.RemoveAll(user => user.Email == currentUserEmail);
                users.Add(editForm.newUser);
                users = users.OrderBy(user => user.Email).ToList();

                if (editingLoggedInUser)
                {
                    // this enables to change "logged in as: " label on the home screen as is edited
                    loggedInUser = editForm.newUser;
                }

                displayUsers();
                listBoxUsers.SelectedItem = editForm.newUser;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            frmAdd addForm = new frmAdd(this, users);
            addForm.ShowDialog();

            if (addForm.addCompleted == true)
            {
                users.Add(addForm.newUser);
                users = users.OrderBy(user => user.Email).ToList();

                displayUsers();
                listBoxUsers.SelectedItem = addForm.newUser;
            }
        }
    }
}
