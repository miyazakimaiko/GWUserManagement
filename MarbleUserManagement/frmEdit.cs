using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GWUserManagement
{
    public partial class frmEdit : Form
    {
        // primary key
        private string currentUserEmail;
        private User user;
        public User newUser;
        private List<User> users;

        public bool editCompleted = false;

        public frmEdit(User user, List<User> users, bool userIsAdmin = false)
        {
            InitializeComponent();

            this.user = user;
            this.users = users;
            currentUserEmail = user.Email;

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
            UtilityFilePath.clearErrorLabel(this);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool nameIsValid = UtilityFieldValidation.validateName(textBoxName.Text, labelErrorName);
            bool emailIsValid = UtilityFieldValidation.validateEmail(textBoxEmailAddress.Text, labelErrorEmail);
            bool emailIsUnique = UtilityFieldValidation.isEmailUnique(textBoxEmailAddress.Text, labelErrorEmail, users, currentUserEmail);
            bool phoneIsValid = UtilityFieldValidation.validatePhone(textBoxPhoneNumber.Text, labelErrorPhone);
            bool passwordIsValid = UtilityFieldValidation.validatePassword(textBoxPassword.Text, labelErrorPassword);
            bool passwordRetypeIsValid = UtilityFieldValidation.validatePasswordRetype(textBoxPassword.Text, textBoxPasswordRetype.Text, labelErrorPasswordRetype);
            bool groupIsValid = UtilityFieldValidation.validateGroup(comboBoxGroup.Text, comboBoxGroup, labelErrorGroup);

            if (nameIsValid &
                emailIsValid &
                emailIsUnique &
                phoneIsValid &
                passwordIsValid &
                passwordRetypeIsValid &
                groupIsValid)
            {
                newUser = new User(
                    textBoxEmailAddress.Text,
                    textBoxName.Text,
                    textBoxPhoneNumber.Text,
                    checkBoxAdministraion.Checked,
                    textBoxPassword.Text,
                    comboBoxGroup.Text,
                    textBoxImage.Text);

                try
                {
                    frmConfirm confirmationForm = new frmConfirm("edit", newUser, currentUserEmail);
                    confirmationForm.ShowDialog();

                    if (confirmationForm.completed)
                    {
                        editCompleted = true;
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
            UtilityFilePath.findFilepath(textBoxImage);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            UtilityFieldValidation.validateName(textBoxName.Text, labelErrorName);
        }

        private void textBoxEmailAddress_TextChanged(object sender, EventArgs e)
        {
            UtilityFieldValidation.validateEmail(textBoxEmailAddress.Text, labelErrorEmail);
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            UtilityFieldValidation.validatePhone(textBoxPhoneNumber.Text, labelErrorPhone);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            UtilityFieldValidation.validatePassword(textBoxPassword.Text, labelErrorPassword);
        }

        private void textBoxPasswordRetype_TextChanged(object sender, EventArgs e)
        {
            UtilityFieldValidation.validatePasswordRetype(textBoxPassword.Text, textBoxPasswordRetype.Text, labelErrorPasswordRetype);
        }

        private void textBoxImage_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGroup_TextChanged(object sender, EventArgs e)
        {
            UtilityFieldValidation.validateGroup(comboBoxGroup.Text, comboBoxGroup, labelErrorGroup);
        }
    }
}