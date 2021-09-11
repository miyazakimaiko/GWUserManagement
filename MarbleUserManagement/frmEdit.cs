using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace GWUserManagement
{
    public partial class frmEdit : Form
    {
        private User user;
        public User newUser;
        private List<User> users;
        public frmConfirm confirmationForm;

        // primary key
        private string currentUserEmail;

        public frmEdit(User user, List<User> users, bool userIsAdmin = false)
        {
            InitializeComponent();

            this.user = user;
            this.users = users;
            this.currentUserEmail = user.Email;

            textBoxPassword.PasswordChar = '*';
            textBoxPasswordRetype.PasswordChar = '*';

            if (!userIsAdmin)
            {
                checkBoxAdministraion.Enabled = false;
                comboBoxGroup.Enabled = false;
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            fillTextBoxes();
        }

        private void fillTextBoxes()
        {
            textBoxName.Text = user.Name;
            textBoxEmailAddress.Text = user.Email;
            textBoxPassword.Text = user.Password;
            textBoxPasswordRetype.Text = user.Password;
            textBoxPhoneNumber.Text = user.Phone;
            textBoxImage.Text = user.Image;
            checkBoxAdministraion.Checked = user.IsAdmin;
            comboBoxGroup.SelectedItem = user.Group;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            fillTextBoxes();
            FormUtility.clearErrorLabel(this);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string newName = HttpUtility.HtmlEncode(textBoxName.Text);
            string newEmail = HttpUtility.HtmlEncode(textBoxEmailAddress.Text);
            string newPhone = HttpUtility.HtmlEncode(textBoxPhoneNumber.Text);
            string newPassword = HttpUtility.HtmlEncode(textBoxPassword.Text);
            string newImage = HttpUtility.HtmlEncode(textBoxImage.Text);
            bool newAdmin = checkBoxAdministraion.Checked;
            string newGroup = HttpUtility.HtmlEncode(comboBoxGroup.Text);

            bool nameIsValid = FieldValidationUtility.validateName(newName, labelErrorName);
            bool emailIsValid = FieldValidationUtility.validateEmail(newEmail, labelErrorEmail, users, currentUserEmail);
            bool phoneIsValid = FieldValidationUtility.validatePhone(newPhone, labelErrorPhone);
            bool passwordIsValid = FieldValidationUtility.validatePassword(newPassword, labelErrorPassword);
            bool passwordRetypeIsValid = FieldValidationUtility.validatePasswordRetype(newPassword, textBoxPasswordRetype.Text, labelErrorPasswordRetype);
            bool groupIsValid = FieldValidationUtility.validateGroup(newGroup, comboBoxGroup, labelErrorGroup);

            if (nameIsValid & emailIsValid & phoneIsValid & passwordIsValid & passwordRetypeIsValid & groupIsValid)
            {
                newUser = new User(
                    newEmail,
                    newName,
                    newPhone,
                    newAdmin,
                    newPassword,
                    newGroup,
                    newImage);

                try
                {
                    frmConfirm confirmationForm = new frmConfirm("edit", newUser, currentUserEmail);
                    confirmationForm.ShowDialog();

                    if (confirmationForm.completed)
                    {
                        this.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error:", exception.Message);
                }
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FormUtility.findFilepath(textBoxImage);
        }
    }
}

