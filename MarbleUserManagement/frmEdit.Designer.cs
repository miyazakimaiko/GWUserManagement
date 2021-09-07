
namespace GWUserManagement
{
    partial class frmEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordRetype = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordRetype = new System.Windows.Forms.TextBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelErrorName = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.checkBoxAdministraion = new System.Windows.Forms.CheckBox();
            this.labelAdministration = new System.Windows.Forms.Label();
            this.labelErrorEmail = new System.Windows.Forms.Label();
            this.labelErrorPhone = new System.Windows.Forms.Label();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            this.labelErrorPasswordRetype = new System.Windows.Forms.Label();
            this.labelErrorImage = new System.Windows.Forms.Label();
            this.labelErrorGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(48, 412);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(43, 15);
            this.labelGroup.TabIndex = 10;
            this.labelGroup.Text = "Group:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(46, 170);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(91, 15);
            this.labelPhoneNumber.TabIndex = 8;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(46, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(46, 121);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(87, 15);
            this.labelEmailAddress.TabIndex = 6;
            this.labelEmailAddress.Text = "Email Address: ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(46, 218);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 15);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password:";
            // 
            // labelPasswordRetype
            // 
            this.labelPasswordRetype.AutoSize = true;
            this.labelPasswordRetype.Location = new System.Drawing.Point(47, 268);
            this.labelPasswordRetype.Name = "labelPasswordRetype";
            this.labelPasswordRetype.Size = new System.Drawing.Size(99, 15);
            this.labelPasswordRetype.TabIndex = 12;
            this.labelPasswordRetype.Text = "Password Retype:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(174, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(345, 23);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(174, 118);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(345, 23);
            this.textBoxEmailAddress.TabIndex = 14;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(174, 167);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(345, 23);
            this.textBoxPhoneNumber.TabIndex = 15;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(174, 215);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(345, 23);
            this.textBoxPassword.TabIndex = 16;
            // 
            // textBoxPasswordRetype
            // 
            this.textBoxPasswordRetype.Location = new System.Drawing.Point(174, 265);
            this.textBoxPasswordRetype.Name = "textBoxPasswordRetype";
            this.textBoxPasswordRetype.Size = new System.Drawing.Size(345, 23);
            this.textBoxPasswordRetype.TabIndex = 17;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Items.AddRange(new object[] {
            "Sales",
            "Marketing",
            "Human Resources",
            "I.T.",
            "Development",
            "Quality Assurance",
            "Accounts",
            "Operations"});
            this.comboBoxGroup.Location = new System.Drawing.Point(175, 409);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(344, 23);
            this.comboBoxGroup.TabIndex = 20;
            // 
            // labelErrorName
            // 
            this.labelErrorName.AutoSize = true;
            this.labelErrorName.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorName.Location = new System.Drawing.Point(176, 53);
            this.labelErrorName.Name = "labelErrorName";
            this.labelErrorName.Size = new System.Drawing.Size(0, 15);
            this.labelErrorName.TabIndex = 21;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(305, 468);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(99, 31);
            this.buttonReset.TabIndex = 22;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(420, 468);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(99, 31);
            this.buttonSubmit.TabIndex = 23;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxImage
            // 
            this.textBoxImage.Location = new System.Drawing.Point(174, 317);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(278, 23);
            this.textBoxImage.TabIndex = 25;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(47, 320);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(43, 15);
            this.labelImage.TabIndex = 24;
            this.labelImage.Text = "Image:";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(458, 317);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(61, 23);
            this.buttonFind.TabIndex = 26;
            this.buttonFind.Text = "Find..";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdministraion
            // 
            this.checkBoxAdministraion.AutoSize = true;
            this.checkBoxAdministraion.Location = new System.Drawing.Point(176, 362);
            this.checkBoxAdministraion.Name = "checkBoxAdministraion";
            this.checkBoxAdministraion.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAdministraion.TabIndex = 50;
            this.checkBoxAdministraion.UseVisualStyleBackColor = true;
            // 
            // labelAdministration
            // 
            this.labelAdministration.AutoSize = true;
            this.labelAdministration.Location = new System.Drawing.Point(49, 361);
            this.labelAdministration.Name = "labelAdministration";
            this.labelAdministration.Size = new System.Drawing.Size(88, 15);
            this.labelAdministration.TabIndex = 49;
            this.labelAdministration.Text = "Administraion: ";
            // 
            // labelErrorEmail
            // 
            this.labelErrorEmail.AutoSize = true;
            this.labelErrorEmail.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorEmail.Location = new System.Drawing.Point(174, 101);
            this.labelErrorEmail.Name = "labelErrorEmail";
            this.labelErrorEmail.Size = new System.Drawing.Size(0, 15);
            this.labelErrorEmail.TabIndex = 51;
            // 
            // labelErrorPhone
            // 
            this.labelErrorPhone.AutoSize = true;
            this.labelErrorPhone.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorPhone.Location = new System.Drawing.Point(175, 149);
            this.labelErrorPhone.Name = "labelErrorPhone";
            this.labelErrorPhone.Size = new System.Drawing.Size(0, 15);
            this.labelErrorPhone.TabIndex = 52;
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorPassword.Location = new System.Drawing.Point(174, 197);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Size = new System.Drawing.Size(0, 15);
            this.labelErrorPassword.TabIndex = 53;
            // 
            // labelErrorPasswordRetype
            // 
            this.labelErrorPasswordRetype.AutoSize = true;
            this.labelErrorPasswordRetype.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorPasswordRetype.Location = new System.Drawing.Point(174, 245);
            this.labelErrorPasswordRetype.Name = "labelErrorPasswordRetype";
            this.labelErrorPasswordRetype.Size = new System.Drawing.Size(0, 15);
            this.labelErrorPasswordRetype.TabIndex = 54;
            // 
            // labelErrorImage
            // 
            this.labelErrorImage.AutoSize = true;
            this.labelErrorImage.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorImage.Location = new System.Drawing.Point(174, 299);
            this.labelErrorImage.Name = "labelErrorImage";
            this.labelErrorImage.Size = new System.Drawing.Size(0, 15);
            this.labelErrorImage.TabIndex = 55;
            // 
            // labelErrorGroup
            // 
            this.labelErrorGroup.AutoSize = true;
            this.labelErrorGroup.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorGroup.Location = new System.Drawing.Point(174, 392);
            this.labelErrorGroup.Name = "labelErrorGroup";
            this.labelErrorGroup.Size = new System.Drawing.Size(0, 15);
            this.labelErrorGroup.TabIndex = 56;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 545);
            this.Controls.Add(this.labelErrorGroup);
            this.Controls.Add(this.labelErrorImage);
            this.Controls.Add(this.labelErrorPasswordRetype);
            this.Controls.Add(this.labelErrorPassword);
            this.Controls.Add(this.labelErrorPhone);
            this.Controls.Add(this.labelErrorEmail);
            this.Controls.Add(this.checkBoxAdministraion);
            this.Controls.Add(this.labelAdministration);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxImage);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelErrorName);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.textBoxPasswordRetype);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPasswordRetype);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelEmailAddress);
            this.Name = "frmEdit";
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordRetype;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPasswordRetype;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelErrorName;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.CheckBox checkBoxAdministraion;
        private System.Windows.Forms.Label labelAdministration;
        private System.Windows.Forms.Label labelErrorEmail;
        private System.Windows.Forms.Label labelErrorPhone;
        private System.Windows.Forms.Label labelErrorPassword;
        private System.Windows.Forms.Label labelErrorPasswordRetype;
        private System.Windows.Forms.Label labelErrorImage;
        private System.Windows.Forms.Label labelErrorGroup;
    }
}