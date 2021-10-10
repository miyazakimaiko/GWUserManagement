using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GWUserManagement
{
    public partial class frmAdd : Form
    {
        public User newUser;
        private List<User> users;

        public bool addCompleted = false;

        public frmAdd(frmHome home, List<User> users)
        {
            InitializeComponent();

            this.users = users;

            textBoxPassword.PasswordChar = '*';
            textBoxPasswordRetype.PasswordChar = '*';
        }

        private void frmAdd_Load(object sender, EventArgs e) 
        {
            toolTipName.SetToolTip(labelName, "Name can only contain alphabet and number.");
            toolTipEmail.SetToolTip(labelEmailAddress,
                "Must be email format. (e.g. sample@test.com).\r\n" +
                "Email address that is already used by other user cannot be used.");
            toolTipPhone.SetToolTip(labelPhoneNumber, "Only + symbol, number and space are accepted.");
            toolTipPassword.SetToolTip(labelPassword,
                "Password should contain at least one lower case letter, one upper case letter,\r\n" +
                "one numeric value, and one special case character.\r\n" +
                "Password should not be lesser than 8 or greater than 15 characters.");
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool nameIsValid = UtilityFieldValidation.validateName(textBoxName.Text, labelErrorName);
            bool emailIsValid = UtilityFieldValidation.validateEmail(textBoxEmailAddress.Text, labelErrorEmail);
            bool emailIsUnique = UtilityFieldValidation.isEmailUnique(textBoxEmailAddress.Text, labelErrorEmail, users);
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
                    frmConfirm confirmationForm = new frmConfirm("add", newUser);
                    confirmationForm.ShowDialog();

                    if (confirmationForm.completed)
                    {
                        this.addCompleted = true;
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
