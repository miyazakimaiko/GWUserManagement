using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GWUserManagement
{
    class UtilityFieldValidation
    {
        public static bool validateName(string name, Label errorLabel)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                errorLabel.Text = "This field cannot be empty.";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z0-9\x20']+$"))
            {
                errorLabel.Text = "Name can only contain alphabet and number.";
                return false;
            }
            else
            {
                errorLabel.Text = "";
                return true;
            }
        }

        public static bool validateEmail(string newEmail, Label errorLabel)
        {
            // If currentEmail is not null, that means the form is editing existing user
            // otherwise creating new user.

            if (string.IsNullOrWhiteSpace(newEmail))
            {
                errorLabel.Text = "This field cannot be empty.";
                return false;
            }

            try
            {
                MailAddress m = new MailAddress(newEmail);
                errorLabel.Text = "";
                return true;
            }
            catch (FormatException)
            {
                errorLabel.Text = "Please enter email format.";
                return false;
            }
        }

        public static bool isEmailUnique(string newEmail, Label errorLabel, List<User> users, string currentEmail = null)
        {
            foreach (User user in users)
            {
                if (user.Email == currentEmail)
                {
                    continue;
                }
                else if (user.Email == newEmail)
                {
                    errorLabel.Text = "This email is already taken.";
                    return false;
                }
            }
            return true;
        }

        public static bool validatePhone(string phone, Label errorLabel)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                errorLabel.Text = "This field cannot be empty.";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^[0-9\x20\+]+$"))
            {
                errorLabel.Text = "Only + symbol and number is accepted.";
                return false;
            }
            else
            {
                errorLabel.Text = "";
                return true;
            }
        }

        public static bool validatePassword(string pwd, Label errorLabel)
        {
            if (string.IsNullOrWhiteSpace(pwd))
            {
                errorLabel.Text = "This field cannot be empty.";
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(pwd))
            {
                errorLabel.Text = "Password should contain at least one lower case letter.";
                return false;
            }
            else if (!hasUpperChar.IsMatch(pwd))
            {
                errorLabel.Text = "Password should contain at least one upper case letter.";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(pwd))
            {
                errorLabel.Text = "Password should not be lesser than 8 or greater than 15 characters.";
                return false;
            }
            else if (!hasNumber.IsMatch(pwd))
            {
                errorLabel.Text = "Password should contain at least one numeric value.";
                return false;
            }

            else if (!hasSymbols.IsMatch(pwd))
            {
                errorLabel.Text = "Password should contain at least one special case character.";
                return false;
            }
            else
            {
                errorLabel.Text = "";
                return true;
            }
        }

        public static bool validatePasswordRetype(string pwd, string pwdRetype, Label errorLabel)
        {
            if (string.IsNullOrWhiteSpace(pwdRetype))
            {
                errorLabel.Text = "This field cannot be empty.";
                return false;
            }
            else if (pwd != pwdRetype)
            {
                errorLabel.Text = "Password does not match.";
                return false;
            }
            else
            {
                errorLabel.Text = "";
                return true;
            }
        }

        public static bool validateGroup(string group, ComboBox comboBox, Label errorLabel)
        {
            if (string.IsNullOrWhiteSpace(group))
            {
                errorLabel.Text = "This field cannot be empty.";
                return false;
            }
            else if (!comboBox.Items.Contains(group))
            {
                errorLabel.Text = "This group name does not exist.";
                return false;
            }
            else
            {
                errorLabel.Text = "";
                return true;
            }
        }
    }
}
