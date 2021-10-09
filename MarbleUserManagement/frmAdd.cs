using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GWUserManagement
{
    public partial class frmAdd : Form
    {
        public User newUser;
        private List<User> users;
        public frmConfirm confirmationForm;

        public bool addCompleted = false;

        bool nameIsValid;
        bool emailIsValid;
        bool phoneIsValid;
        bool passwordIsValid;
        bool passwordRetypeIsValid;
        bool groupIsValid;

        public frmAdd(frmHome home, List<User> users)
        {
            InitializeComponent();

            this.users = users;

            textBoxPassword.PasswordChar = '*';
            textBoxPasswordRetype.PasswordChar = '*';
        }

        private void frmAdd_Load(object sender, EventArgs e) {}

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (nameIsValid & emailIsValid & phoneIsValid & passwordIsValid & passwordRetypeIsValid & groupIsValid)
            {
                bool emailIsAvailable = UtilityFieldValidation.isEmailAvailable(textBoxEmailAddress.Text, labelErrorEmail, users);

                if (!emailIsAvailable)
                    return;

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
                    confirmationForm = new frmConfirm("add", newUser);
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
            this.nameIsValid = UtilityFieldValidation.validateName(textBoxName.Text, labelErrorName);
        }

        private void textBoxEmailAddress_TextChanged(object sender, EventArgs e)
        {
            this.emailIsValid = UtilityFieldValidation.validateEmail(textBoxEmailAddress.Text, labelErrorEmail);
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            this.phoneIsValid = UtilityFieldValidation.validatePhone(textBoxPhoneNumber.Text, labelErrorPhone);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            this.passwordIsValid = UtilityFieldValidation.validatePassword(textBoxPassword.Text, labelErrorPassword);
        }

        private void textBoxPasswordRetype_TextChanged(object sender, EventArgs e)
        {
            this.passwordRetypeIsValid = UtilityFieldValidation.validatePasswordRetype(
                textBoxPassword.Text, textBoxPasswordRetype.Text, labelErrorPasswordRetype);
        }

        private void textBoxImage_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGroup_TextChanged(object sender, EventArgs e)
        {
            this.groupIsValid = UtilityFieldValidation.validateGroup(
                comboBoxGroup.Text, comboBoxGroup, labelErrorGroup);
        }
    }
}
