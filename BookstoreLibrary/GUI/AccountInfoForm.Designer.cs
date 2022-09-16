namespace BookstoreLibrary.GUI
{
    partial class AccountInfoForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PhoneCodesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ShowAddressButton = new System.Windows.Forms.Button();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.RolesComboBox = new System.Windows.Forms.ComboBox();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.AllowEditsCheckBox = new System.Windows.Forms.CheckBox();
            this.ChangesChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(322, 157);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(102, 29);
            this.SaveButton.TabIndex = 35;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(2, 157);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(102, 29);
            this.GoBackButton.TabIndex = 34;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Username:";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Enabled = false;
            this.UsernameBox.Location = new System.Drawing.Point(168, 50);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(184, 20);
            this.UsernameBox.TabIndex = 32;
            // 
            // PhoneCodesComboBox
            // 
            this.PhoneCodesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PhoneCodesComboBox.Enabled = false;
            this.PhoneCodesComboBox.FormattingEnabled = true;
            this.PhoneCodesComboBox.Location = new System.Drawing.Point(169, 92);
            this.PhoneCodesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneCodesComboBox.Name = "PhoneCodesComboBox";
            this.PhoneCodesComboBox.Size = new System.Drawing.Size(55, 21);
            this.PhoneCodesComboBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Phone number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name:";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Enabled = false;
            this.PhoneBox.Location = new System.Drawing.Point(226, 92);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(126, 20);
            this.PhoneBox.TabIndex = 27;
            // 
            // EmailBox
            // 
            this.EmailBox.Enabled = false;
            this.EmailBox.Location = new System.Drawing.Point(168, 72);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(184, 20);
            this.EmailBox.TabIndex = 25;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Enabled = false;
            this.SurnameBox.Location = new System.Drawing.Point(168, 28);
            this.SurnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(184, 20);
            this.SurnameBox.TabIndex = 24;
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(168, 7);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(184, 20);
            this.NameBox.TabIndex = 23;
            // 
            // ShowAddressButton
            // 
            this.ShowAddressButton.Location = new System.Drawing.Point(108, 157);
            this.ShowAddressButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAddressButton.Name = "ShowAddressButton";
            this.ShowAddressButton.Size = new System.Drawing.Size(102, 29);
            this.ShowAddressButton.TabIndex = 36;
            this.ShowAddressButton.Text = "Show address";
            this.ShowAddressButton.UseVisualStyleBackColor = true;
            this.ShowAddressButton.Click += new System.EventHandler(this.ShowAddressButton_Click);
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(72, 116);
            this.RoleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(32, 13);
            this.RoleLabel.TabIndex = 37;
            this.RoleLabel.Text = "Role:";
            // 
            // RolesComboBox
            // 
            this.RolesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolesComboBox.Enabled = false;
            this.RolesComboBox.FormattingEnabled = true;
            this.RolesComboBox.Location = new System.Drawing.Point(168, 113);
            this.RolesComboBox.Name = "RolesComboBox";
            this.RolesComboBox.Size = new System.Drawing.Size(184, 21);
            this.RolesComboBox.TabIndex = 38;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(215, 157);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(102, 29);
            this.ChangePasswordButton.TabIndex = 39;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            // 
            // AllowEditsCheckBox
            // 
            this.AllowEditsCheckBox.AutoSize = true;
            this.AllowEditsCheckBox.Location = new System.Drawing.Point(71, 135);
            this.AllowEditsCheckBox.Name = "AllowEditsCheckBox";
            this.AllowEditsCheckBox.Size = new System.Drawing.Size(76, 17);
            this.AllowEditsCheckBox.TabIndex = 40;
            this.AllowEditsCheckBox.Text = "Allow edits";
            this.AllowEditsCheckBox.UseVisualStyleBackColor = true;
            this.AllowEditsCheckBox.CheckedChanged += new System.EventHandler(this.AllowEditsCheckBox_CheckedChanged);
            // 
            // ChangesChecker
            // 
            this.ChangesChecker.Tick += new System.EventHandler(this.ChangesChecker_Tick);
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 192);
            this.Controls.Add(this.AllowEditsCheckBox);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.RolesComboBox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.ShowAddressButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.PhoneCodesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Name = "AccountInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.ComboBox PhoneCodesComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button ShowAddressButton;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.ComboBox RolesComboBox;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.CheckBox AllowEditsCheckBox;
        private System.Windows.Forms.Timer ChangesChecker;
    }
}