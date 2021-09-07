
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 15;
            this.listBoxUsers.Location = new System.Drawing.Point(56, 92);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(176, 394);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.TextChanged += new System.EventHandler(this.listBoxUsers_Select);
            this.listBoxUsers.SelectedValueChanged += new System.EventHandler(this.listBoxUsers_Select);
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(294, 325);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(87, 15);
            this.labelEmailAddress.TabIndex = 1;
            this.labelEmailAddress.Text = "Email Address: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(294, 286);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(294, 361);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(91, 15);
            this.labelPhoneNumber.TabIndex = 3;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // labelAdministration
            // 
            this.labelAdministration.AutoSize = true;
            this.labelAdministration.Location = new System.Drawing.Point(294, 397);
            this.labelAdministration.Name = "labelAdministration";
            this.labelAdministration.Size = new System.Drawing.Size(89, 15);
            this.labelAdministration.TabIndex = 4;
            this.labelAdministration.Text = "Administration:";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(294, 434);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(43, 15);
            this.labelGroup.TabIndex = 5;
            this.labelGroup.Text = "Group:";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(383, 92);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(149, 134);
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(551, 505);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(91, 33);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(441, 505);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 33);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(56, 505);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 33);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add New User";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(415, 283);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(227, 23);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(415, 322);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.ReadOnly = true;
            this.textBoxEmailAddress.Size = new System.Drawing.Size(227, 23);
            this.textBoxEmailAddress.TabIndex = 11;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(415, 358);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ReadOnly = true;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(227, 23);
            this.textBoxPhoneNumber.TabIndex = 12;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(415, 431);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.ReadOnly = true;
            this.textBoxGroup.Size = new System.Drawing.Size(227, 23);
            this.textBoxGroup.TabIndex = 13;
            // 
            // checkBoxAdministration
            // 
            this.checkBoxAdministration.AutoSize = true;
            this.checkBoxAdministration.Enabled = false;
            this.checkBoxAdministration.Location = new System.Drawing.Point(415, 398);
            this.checkBoxAdministration.Name = "checkBoxAdministration";
            this.checkBoxAdministration.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAdministration.TabIndex = 14;
            this.checkBoxAdministration.UseVisualStyleBackColor = true;
            // 
            // labelLoggedInName
            // 
            this.labelLoggedInName.AutoSize = true;
            this.labelLoggedInName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoggedInName.ForeColor = System.Drawing.Color.Brown;
            this.labelLoggedInName.Location = new System.Drawing.Point(56, 41);
            this.labelLoggedInName.Name = "labelLoggedInName";
            this.labelLoggedInName.Size = new System.Drawing.Size(0, 15);
            this.labelLoggedInName.TabIndex = 15;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 585);
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
    }
}