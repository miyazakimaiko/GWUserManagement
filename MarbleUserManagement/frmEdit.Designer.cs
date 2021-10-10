
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
            this.components = new System.ComponentModel.Container();
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
            this.toolTipResetButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipName = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEmail = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPhone = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(90, 879);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(85, 32);
            this.labelGroup.TabIndex = 10;
            this.labelGroup.Text = "Group:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(86, 362);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(182, 32);
            this.labelPhoneNumber.TabIndex = 8;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(86, 157);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 32);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(86, 259);
            this.labelEmailAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(174, 32);
            this.labelEmailAddress.TabIndex = 6;
            this.labelEmailAddress.Text = "Email Address: ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(86, 465);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(116, 32);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password:";
            // 
            // labelPasswordRetype
            // 
            this.labelPasswordRetype.AutoSize = true;
            this.labelPasswordRetype.Location = new System.Drawing.Point(87, 572);
            this.labelPasswordRetype.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPasswordRetype.Name = "labelPasswordRetype";
            this.labelPasswordRetype.Size = new System.Drawing.Size(196, 32);
            this.labelPasswordRetype.TabIndex = 12;
            this.labelPasswordRetype.Text = "Password Retype:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(324, 151);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(637, 39);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(324, 252);
            this.textBoxEmailAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(637, 39);
            this.textBoxEmailAddress.TabIndex = 14;
            this.textBoxEmailAddress.TextChanged += new System.EventHandler(this.textBoxEmailAddress_TextChanged);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(324, 356);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(637, 39);
            this.textBoxPhoneNumber.TabIndex = 15;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(324, 458);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(637, 39);
            this.textBoxPassword.TabIndex = 16;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxPasswordRetype
            // 
            this.textBoxPasswordRetype.Location = new System.Drawing.Point(324, 566);
            this.textBoxPasswordRetype.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxPasswordRetype.Name = "textBoxPasswordRetype";
            this.textBoxPasswordRetype.Size = new System.Drawing.Size(637, 39);
            this.textBoxPasswordRetype.TabIndex = 17;
            this.textBoxPasswordRetype.TextChanged += new System.EventHandler(this.textBoxPasswordRetype_TextChanged);
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
            this.comboBoxGroup.Location = new System.Drawing.Point(325, 873);
            this.comboBoxGroup.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(636, 40);
            this.comboBoxGroup.TabIndex = 20;
            this.comboBoxGroup.TextChanged += new System.EventHandler(this.comboBoxGroup_TextChanged);
            // 
            // labelErrorName
            // 
            this.labelErrorName.AutoSize = true;
            this.labelErrorName.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorName.Location = new System.Drawing.Point(326, 113);
            this.labelErrorName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelErrorName.Name = "labelErrorName";
            this.labelErrorName.Size = new System.Drawing.Size(0, 32);
            this.labelErrorName.TabIndex = 21;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(567, 998);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(183, 67);
            this.buttonReset.TabIndex = 22;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(780, 998);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(183, 67);
            this.buttonSubmit.TabIndex = 23;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxImage
            // 
            this.textBoxImage.Location = new System.Drawing.Point(324, 676);
            this.textBoxImage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.ReadOnly = true;
            this.textBoxImage.Size = new System.Drawing.Size(512, 39);
            this.textBoxImage.TabIndex = 25;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(87, 682);
            this.labelImage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(85, 32);
            this.labelImage.TabIndex = 24;
            this.labelImage.Text = "Image:";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(850, 676);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(113, 49);
            this.buttonFind.TabIndex = 26;
            this.buttonFind.Text = "Find..";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // checkBoxAdministraion
            // 
            this.checkBoxAdministraion.AutoSize = true;
            this.checkBoxAdministraion.Location = new System.Drawing.Point(326, 772);
            this.checkBoxAdministraion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBoxAdministraion.Name = "checkBoxAdministraion";
            this.checkBoxAdministraion.Size = new System.Drawing.Size(28, 27);
            this.checkBoxAdministraion.TabIndex = 50;
            this.checkBoxAdministraion.UseVisualStyleBackColor = true;
            // 
            // labelAdministration
            // 
            this.labelAdministration.AutoSize = true;
            this.labelAdministration.Location = new System.Drawing.Point(91, 771);
            this.labelAdministration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAdministration.Name = "labelAdministration";
            this.labelAdministration.Size = new System.Drawing.Size(174, 32);
            this.labelAdministration.TabIndex = 49;
            this.labelAdministration.Text = "Administraion: ";
            // 
            // labelErrorEmail
            // 
            this.labelErrorEmail.AutoSize = true;
            this.labelErrorEmail.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorEmail.Location = new System.Drawing.Point(324, 215);
            this.labelErrorEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelErrorEmail.Name = "labelErrorEmail";
            this.labelErrorEmail.Size = new System.Drawing.Size(0, 32);
            this.labelErrorEmail.TabIndex = 51;
            // 
            // labelErrorPhone
            // 
            this.labelErrorPhone.AutoSize = true;
            this.labelErrorPhone.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorPhone.Location = new System.Drawing.Point(325, 317);
            this.labelErrorPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelErrorPhone.Name = "labelErrorPhone";
            this.labelErrorPhone.Size = new System.Drawing.Size(0, 32);
            this.labelErrorPhone.TabIndex = 52;
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorPassword.Location = new System.Drawing.Point(324, 420);
            this.labelErrorPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Size = new System.Drawing.Size(0, 32);
            this.labelErrorPassword.TabIndex = 53;
            // 
            // labelErrorPasswordRetype
            // 
            this.labelErrorPasswordRetype.AutoSize = true;
            this.labelErrorPasswordRetype.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorPasswordRetype.Location = new System.Drawing.Point(324, 522);
            this.labelErrorPasswordRetype.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelErrorPasswordRetype.Name = "labelErrorPasswordRetype";
            this.labelErrorPasswordRetype.Size = new System.Drawing.Size(0, 32);
            this.labelErrorPasswordRetype.TabIndex = 54;
            // 
            // labelErrorImage
            // 
            this.labelErrorImage.AutoSize = true;
            this.labelErrorImage.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorImage.Location = new System.Drawing.Point(324, 637);
            this.labelErrorImage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelErrorImage.Name = "labelErrorImage";
            this.labelErrorImage.Size = new System.Drawing.Size(0, 32);
            this.labelErrorImage.TabIndex = 55;
            // 
            // labelErrorGroup
            // 
            this.labelErrorGroup.AutoSize = true;
            this.labelErrorGroup.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorGroup.Location = new System.Drawing.Point(324, 836);
            this.labelErrorGroup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelErrorGroup.Name = "labelErrorGroup";
            this.labelErrorGroup.Size = new System.Drawing.Size(0, 32);
            this.labelErrorGroup.TabIndex = 56;
            // 
            // toolTipResetButton
            // 
            this.toolTipResetButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipName
            // 
            this.toolTipName.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipEmail
            // 
            this.toolTipEmail.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipPhone
            // 
            this.toolTipPhone.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipPassword
            // 
            this.toolTipPassword.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 1162);
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
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
        private System.Windows.Forms.ToolTip toolTipResetButton;
        private System.Windows.Forms.ToolTip toolTipName;
        private System.Windows.Forms.ToolTip toolTipEmail;
        private System.Windows.Forms.ToolTip toolTipPhone;
        private System.Windows.Forms.ToolTip toolTipPassword;
    }
}