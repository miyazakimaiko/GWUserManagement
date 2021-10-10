
namespace GWUserManagement
{
    partial class frmHome
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
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelAdministration = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.checkBoxAdministration = new System.Windows.Forms.CheckBox();
            this.labelLoggedInName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 32;
            this.listBoxUsers.Location = new System.Drawing.Point(104, 196);
            this.listBoxUsers.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(323, 836);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.TextChanged += new System.EventHandler(this.listBoxUsers_Select);
            this.listBoxUsers.SelectedValueChanged += new System.EventHandler(this.listBoxUsers_Select);
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(546, 693);
            this.labelEmailAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(174, 32);
            this.labelEmailAddress.TabIndex = 1;
            this.labelEmailAddress.Text = "Email Address: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(546, 610);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 32);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(546, 770);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(182, 32);
            this.labelPhoneNumber.TabIndex = 3;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // labelAdministration
            // 
            this.labelAdministration.AutoSize = true;
            this.labelAdministration.Location = new System.Drawing.Point(546, 847);
            this.labelAdministration.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAdministration.Name = "labelAdministration";
            this.labelAdministration.Size = new System.Drawing.Size(175, 32);
            this.labelAdministration.TabIndex = 4;
            this.labelAdministration.Text = "Administration:";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(546, 926);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(85, 32);
            this.labelGroup.TabIndex = 5;
            this.labelGroup.Text = "Group:";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(722, 226);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(305, 305);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1023, 1077);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(169, 70);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(819, 1077);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(169, 70);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(104, 1077);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(204, 70);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add New User";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(771, 604);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(418, 39);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(771, 687);
            this.textBoxEmailAddress.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.ReadOnly = true;
            this.textBoxEmailAddress.Size = new System.Drawing.Size(418, 39);
            this.textBoxEmailAddress.TabIndex = 11;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(771, 764);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ReadOnly = true;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(418, 39);
            this.textBoxPhoneNumber.TabIndex = 12;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(771, 919);
            this.textBoxGroup.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.ReadOnly = true;
            this.textBoxGroup.Size = new System.Drawing.Size(418, 39);
            this.textBoxGroup.TabIndex = 13;
            // 
            // checkBoxAdministration
            // 
            this.checkBoxAdministration.AutoSize = true;
            this.checkBoxAdministration.Enabled = false;
            this.checkBoxAdministration.Location = new System.Drawing.Point(771, 849);
            this.checkBoxAdministration.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxAdministration.Name = "checkBoxAdministration";
            this.checkBoxAdministration.Size = new System.Drawing.Size(28, 27);
            this.checkBoxAdministration.TabIndex = 14;
            this.checkBoxAdministration.UseVisualStyleBackColor = true;
            // 
            // labelLoggedInName
            // 
            this.labelLoggedInName.AutoSize = true;
            this.labelLoggedInName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoggedInName.ForeColor = System.Drawing.Color.Black;
            this.labelLoggedInName.Location = new System.Drawing.Point(104, 61);
            this.labelLoggedInName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLoggedInName.Name = "labelLoggedInName";
            this.labelLoggedInName.Size = new System.Drawing.Size(0, 32);
            this.labelLoggedInName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Users :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "User Details :";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 1246);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLoggedInName);
            this.Controls.Add(this.checkBoxAdministration);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelAdministration);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.listBoxUsers);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmHome";
            this.Text = "GroundWorks User Management System";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelAdministration;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.CheckBox checkBoxAdministration;
        private System.Windows.Forms.Label labelLoggedInName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}