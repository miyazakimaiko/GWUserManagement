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

        public bool dbSuccessful;

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
            string newName = HttpUtility.HtmlEncode(textBoxName.Text);
            string newEmail = HttpUtility.HtmlEncode(textBoxEmailAddress.Text);
            string newPhone = HttpUtility.HtmlEncode(textBoxPhoneNumber.Text);
            string newPassword = HttpUtility.HtmlEncode(textBoxPassword.Text);
            string newImage = HttpUtility.HtmlEncode(textBoxImage.Text);
            bool newAdmin = checkBoxAdministraion.Checked;
            string newGroup = HttpUtility.HtmlEncode(comboBoxGroup.Text);

            bool nameIsValid = FieldValidationUtility.validateName(newName, labelErrorName);
            bool emailIsValid = FieldValidationUtility.validateEmail(newEmail, labelErrorEmail, users);
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
                    confirmationForm = new frmConfirm("add", newUser);
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
