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
    public partial class frmEditConfirm : Form
    {
        private string email;
        private User user;

        public frmEditConfirm(string email, User user)
        {
            InitializeComponent();

            this.email = email;
            this.user = user;
        }

        private void frmEditConfirm_Load(object sender, EventArgs e)
        {
            labelName.Text = user.Name;
            labelEmail.Text = user.Email;
            labelPhone.Text = user.Phone;
            labelPassword.Text = String.Concat(Enumerable.Repeat("*", user.Password.Length));
            labelImage.Text = user.Image;
            labelAdministration.Text = user.IsAdmin ? "Yes" : "No";
            labelGroup.Text = user.Group;
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection("localhost", "usermanagement", "root", "Maiko119922");
            DBUsers dbUsers = new DBUsers();

            connection.OpenConnection();

            dbUsers.Update(connection, this.email, this.user);

            this.Close();
        }
    }
}
