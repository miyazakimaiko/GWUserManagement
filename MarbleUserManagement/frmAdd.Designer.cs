
namespace GWUserManagement
{
    partial class frmAdd
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
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.textBoxPasswordRetype = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPasswordRetype = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelAdministration = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.checkBoxAdministraion = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(349, 250);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(61, 23);
            this.buttonFind.TabIndex = 47;
            this.buttonFind.Text = "Find..";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 23);
            this.textBox1.TabIndex = 46;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(40, 254);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(43, 15);
            this.labelImage.TabIndex = 45;
            this.labelImage.Text = "Image:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(311, 392);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(99, 31);
            this.buttonSubmit.TabIndex = 44;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(196, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 31);
            this.buttonCancel.TabIndex = 43;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(167, 19);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(89, 15);
            this.labelError.TabIndex = 42;
            this.labelError.Text = "(Error Message)";
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
            this.comboBoxGroup.Location = new System.Drawing.Point(167, 332);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(243, 23);
            this.comboBoxGroup.TabIndex = 41;
            // 
            // textBoxPasswordRetype
            // 
            this.textBoxPasswordRetype.Location = new System.Drawing.Point(167, 212);
            this.textBoxPasswordRetype.Name = "textBoxPasswordRetype";
            this.textBoxPasswordRetype.Size = new System.Drawing.Size(243, 23);
            this.textBoxPasswordRetype.TabIndex = 38;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(167, 174);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(243, 23);
            this.textBoxPassword.TabIndex = 37;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(167, 139);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(243, 23);
            this.textBoxPhoneNumber.TabIndex = 36;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(167, 103);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(243, 23);
            this.textBoxEmailAddress.TabIndex = 35;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(167, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(243, 23);
            this.textBoxName.TabIndex = 34;
            // 
            // labelPasswordRetype
            // 
            this.labelPasswordRetype.AutoSize = true;
            this.labelPasswordRetype.Location = new System.Drawing.Point(40, 215);
            this.labelPasswordRetype.Name = "labelPasswordRetype";
            this.labelPasswordRetype.Size = new System.Drawing.Size(99, 15);
            this.labelPasswordRetype.TabIndex = 33;
            this.labelPasswordRetype.Text = "Password Retype:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(39, 177);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 15);
            this.labelPassword.TabIndex = 32;
            this.labelPassword.Text = "Password:";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(40, 335);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(43, 15);
            this.labelGroup.TabIndex = 31;
            this.labelGroup.Text = "Group:";
            // 
            // labelAdministration
            // 
            this.labelAdministration.AutoSize = true;
            this.labelAdministration.Location = new System.Drawing.Point(40, 298);
            this.labelAdministration.Name = "labelAdministration";
            this.labelAdministration.Size = new System.Drawing.Size(88, 15);
            this.labelAdministration.TabIndex = 30;
            this.labelAdministration.Text = "Administraion: ";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(39, 142);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(91, 15);
            this.labelPhoneNumber.TabIndex = 29;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(39, 67);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 28;
            this.labelName.Text = "Name:";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(39, 106);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(87, 15);
            this.labelEmailAddress.TabIndex = 27;
            this.labelEmailAddress.Text = "Email Address: ";
            // 
            // checkBoxAdministraion
            // 
            this.checkBoxAdministraion.AutoSize = true;
            this.checkBoxAdministraion.Location = new System.Drawing.Point(167, 299);
            this.checkBoxAdministraion.Name = "checkBoxAdministraion";
            this.checkBoxAdministraion.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAdministraion.TabIndex = 48;
            this.checkBoxAdministraion.UseVisualStyleBackColor = true;
            this.checkBoxAdministraion.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 462);
            this.Controls.Add(this.checkBoxAdministraion);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.textBoxPasswordRetype);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPasswordRetype);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelAdministration);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelEmailAddress);
            this.Name = "frmAdd";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.TextBox textBoxPasswordRetype;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPasswordRetype;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelAdministration;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.CheckBox checkBoxAdministraion;
    }
}