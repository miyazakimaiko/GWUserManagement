using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GWUserManagement
{
    public partial class frmEdit : Form
    {
        // edit or add
        string requestType;

        private User user;
        public User newUser;
        private List<User> users;

        // primary key
        private string currentUserEmail;

        private bool editingLoggedInUser = false;
        frmHome home;

        public frmEdit(frmHome home, User user, List<User> users, string type)
        {
            InitializeComponent();

            this.requestType = type;
            this.user = user;
            this.users = users;
            this.currentUserEmail = user.Email;
            this.home = home;

            textBoxPassword.PasswordChar = '*';
            textBoxPasswordRetype.PasswordChar = '*';

            if (currentUserEmail == home.loggedInUser.Email)
            {
                editingLoggedInUser = true;
            }

            if (!home.loggedInUser.IsAdmin)
            {
                checkBoxAdministraion.Enabled = false;
                comboBoxGroup.Enabled = false;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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
            clearErrorLabel(this);
        }

        private void clearErrorLabel(Control control)
        {
            if (control is Label)
            {
                Label lbl = (Label)control;
                if (lbl.Name.StartsWith("labelError"))
                    lbl.Text = String.Empty;

            }
            else
                foreach (Control child in control.Controls)
                {
                    clearErrorLabel(child);
                }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool nameIsValid = validateName();
            bool emailIsValid = validateEmail();
            bool phoneIsValid = validatePhone();
            bool passwordIsValid = validatePassword();
            bool passwordRetypeIsValid = validatePasswordRetype();
            bool groupIsValid = validateGroup();

            string newName = HttpUtility.HtmlEncode(textBoxName.Text);
            string newEmail = HttpUtility.HtmlEncode(textBoxEmailAddress.Text);
            string newPhone = HttpUtility.HtmlEncode(textBoxPhoneNumber.Text);
            string newPassword = HttpUtility.HtmlEncode(textBoxPassword.Text);
            string newImage = HttpUtility.HtmlEncode(textBoxImage.Text);
            bool newAdmin = checkBoxAdministraion.Checked;
            string newGroup = HttpUtility.HtmlEncode(comboBoxGroup.Text);

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


                if (requestType == "edit")
                {
                    frmEditConfirm confirmationForm = new frmEditConfirm(currentUserEmail, newUser);
                    confirmationForm.ShowDialog();

                    this.Close();

                    home.users.RemoveAll(user => user.Email == this.currentUserEmail);
                    home.users.Add(newUser);
                    home.users = home.users.OrderBy(user => user.Email).ToList();

                    if (editingLoggedInUser)
                    {
                        // this enables to change "logged in as: " label on the home screen as is edited
                        home.loggedInUser = newUser;
                        editingLoggedInUser = false;
                    }
                }
                else if (requestType == "add")
                {
                    frmEditConfirm confirmationForm = new frmEditConfirm(currentUserEmail, newUser);
                    confirmationForm.ShowDialog();

                    this.Close();

                    home.users.Add(newUser);
                    home.users = home.users.OrderBy(user => user.Email).ToList();
                }


                home.displayUsers();
            }
        }

        private bool validateName()
        {
            string name = textBoxName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                labelErrorName.Text = "This field cannot be empty.";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z0-9\x20']+$"))
            {
                labelErrorName.Text = "Name can only contain alphabet and number.";
                return false;
            }
            else
            {
                labelErrorName.Text = "";
                return true;
            }
        }

        private bool validateEmail()
        {
            string email = textBoxEmailAddress.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                labelErrorEmail.Text = "This field cannot be empty.";
                return false;
            }

            foreach (User user in this.users)
            {
                if (user.Email == currentUserEmail)
                {
                    continue;
                }
                if (user.Email == email)
                {
                    labelErrorEmail.Text = "This email is taken by other users.";
                    return false;
                }
            }

            try
            {
                MailAddress m = new MailAddress(email);
                labelErrorEmail.Text = "";
                return true;
            }
            catch (FormatException)
            {
                labelErrorEmail.Text = "Please enter email format.";
                return false;
            }
        }

        private bool validatePhone()
        {
            string phone = textBoxPhoneNumber.Text;

            if (string.IsNullOrWhiteSpace(phone))
            {
                labelErrorPhone.Text = "This field cannot be empty.";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^[0-9\x20\+]+$"))
            {
                labelErrorPhone.Text = "Only + symbol and number is accepted.";
                return false;
            }
            else
            {
                labelErrorPhone.Text = "";
                return true;
            }
        }

        private bool validatePassword()
        {
            string pwd = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(pwd))
            {
                labelErrorPassword.Text = "This field cannot be empty.";
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            // var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{5,}");

            if (hasNumber.IsMatch(pwd) && hasMinimum8Chars.IsMatch(pwd))
            {
                labelErrorPassword.Text = "";
                return true;
            }
            else
            {
                labelErrorPassword.Text = "Must contain at least a number and 5 characters long.";
                return false;
            }
        }

        private bool validatePasswordRetype()
        {
            string pwd = textBoxPassword.Text;
            string pwdRetype = textBoxPasswordRetype.Text;

            if (string.IsNullOrWhiteSpace(pwdRetype))
            {
                labelErrorPasswordRetype.Text = "This field cannot be empty.";
                return false;
            }
            else if (pwd != pwdRetype)
            {
                labelErrorPasswordRetype.Text = "Password does not match.";
                return false;
            }
            else
            {
                labelErrorPasswordRetype.Text = "";
                return true;
            }
        }

        private bool validateGroup()
        {
            string group = comboBoxGroup.Text;

            if (string.IsNullOrWhiteSpace(group))
            {
                labelErrorGroup.Text = "This field cannot be empty.";
                return false;
            }
            else if (!comboBoxGroup.Items.Contains(group))
            {
                labelErrorGroup.Text = "This group name does not exist.";
                return false;
            }
            else
            {
                labelErrorGroup.Text = "";
                return true;
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBoxImage.Text = file;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }
    }
}

