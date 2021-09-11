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
    class FieldValidationUtility
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

        public static bool validateEmail(string newEmail, Label errorLabel, List<User> users, string currentEmail = null)
        {
            // If currentEmail is not null, that means the form is editing existing user
            // otherwise creating new user.

            if (string.IsNullOrWhiteSpace(newEmail))
            {
                errorLabel.Text = "This field cannot be empty.";
                return false;
            }

            foreach (User user in users)
            {
                if (user.Email == currentEmail)
                {
                    continue;
                }
                else if (user.Email == newEmail)
                {
                    errorLabel.Text = "This email is taken by other users.";
                    return false;
                }
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
            // var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{5,}");

            if (hasNumber.IsMatch(pwd) && hasMinimum8Chars.IsMatch(pwd))
            {
                errorLabel.Text = "";
                return true;
            }
            else
            {
                errorLabel.Text = "Must contain at least a number and 5 characters long.";
                return false;
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
