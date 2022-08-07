namespace BookstoreLibrary.GUI
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CharNumbersPB = new System.Windows.Forms.PictureBox();
            this.SpecialCharPB = new System.Windows.Forms.PictureBox();
            this.CapitalLetterPB = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PasswordMatchPB = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RepeatPasswordBox = new System.Windows.Forms.TextBox();
            this.TermsCheckBox = new System.Windows.Forms.CheckBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.PhoneCodesComboBox = new System.Windows.Forms.ComboBox();
            this.termsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.PostalCodeComboBox = new System.Windows.Forms.ComboBox();
            this.CitiesComboBox = new System.Windows.Forms.ComboBox();
            this.CityComboBox = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.StreetComboBox = new System.Windows.Forms.ComboBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CharNumbersPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialCharPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapitalLetterPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordMatchPB)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(110, 26);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(184, 20);
            this.NameBox.TabIndex = 0;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(110, 47);
            this.SurnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(184, 20);
            this.SurnameBox.TabIndex = 1;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(110, 68);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(184, 20);
            this.EmailBox.TabIndex = 2;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(168, 88);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(126, 20);
            this.PhoneBox.TabIndex = 3;
            this.PhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneBox_KeyPress);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(109, 245);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(184, 20);
            this.UsernameBox.TabIndex = 4;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(109, 266);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(184, 20);
            this.PasswordBox.TabIndex = 5;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password:";
            // 
            // CharNumbersPB
            // 
            this.CharNumbersPB.Image = ((System.Drawing.Image)(resources.GetObject("CharNumbersPB.Image")));
            this.CharNumbersPB.Location = new System.Drawing.Point(15, 309);
            this.CharNumbersPB.Margin = new System.Windows.Forms.Padding(2);
            this.CharNumbersPB.Name = "CharNumbersPB";
            this.CharNumbersPB.Size = new System.Drawing.Size(16, 17);
            this.CharNumbersPB.TabIndex = 12;
            this.CharNumbersPB.TabStop = false;
            // 
            // SpecialCharPB
            // 
            this.SpecialCharPB.Image = ((System.Drawing.Image)(resources.GetObject("SpecialCharPB.Image")));
            this.SpecialCharPB.Location = new System.Drawing.Point(15, 324);
            this.SpecialCharPB.Margin = new System.Windows.Forms.Padding(2);
            this.SpecialCharPB.Name = "SpecialCharPB";
            this.SpecialCharPB.Size = new System.Drawing.Size(16, 17);
            this.SpecialCharPB.TabIndex = 13;
            this.SpecialCharPB.TabStop = false;
            // 
            // CapitalLetterPB
            // 
            this.CapitalLetterPB.Image = ((System.Drawing.Image)(resources.GetObject("CapitalLetterPB.Image")));
            this.CapitalLetterPB.Location = new System.Drawing.Point(15, 339);
            this.CapitalLetterPB.Margin = new System.Windows.Forms.Padding(2);
            this.CapitalLetterPB.Name = "CapitalLetterPB";
            this.CapitalLetterPB.Size = new System.Drawing.Size(16, 17);
            this.CapitalLetterPB.TabIndex = 14;
            this.CapitalLetterPB.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password must contains at least 8 characters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 324);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Password must contains at least one special caracter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 339);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Password must contains at least one capital letter";
            // 
            // PasswordMatchPB
            // 
            this.PasswordMatchPB.Image = ((System.Drawing.Image)(resources.GetObject("PasswordMatchPB.Image")));
            this.PasswordMatchPB.Location = new System.Drawing.Point(15, 354);
            this.PasswordMatchPB.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordMatchPB.Name = "PasswordMatchPB";
            this.PasswordMatchPB.Size = new System.Drawing.Size(16, 17);
            this.PasswordMatchPB.TabIndex = 18;
            this.PasswordMatchPB.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 354);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Passwords have to match";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 289);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Repeat password:";
            // 
            // RepeatPasswordBox
            // 
            this.RepeatPasswordBox.Location = new System.Drawing.Point(109, 287);
            this.RepeatPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.RepeatPasswordBox.Name = "RepeatPasswordBox";
            this.RepeatPasswordBox.Size = new System.Drawing.Size(184, 20);
            this.RepeatPasswordBox.TabIndex = 20;
            this.RepeatPasswordBox.TextChanged += new System.EventHandler(this.RepeatPasswordBox_TextChanged);
            // 
            // TermsCheckBox
            // 
            this.TermsCheckBox.AutoSize = true;
            this.TermsCheckBox.Location = new System.Drawing.Point(16, 375);
            this.TermsCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.TermsCheckBox.Name = "TermsCheckBox";
            this.TermsCheckBox.Size = new System.Drawing.Size(109, 17);
            this.TermsCheckBox.TabIndex = 22;
            this.TermsCheckBox.Text = "I accept the shop";
            this.TermsCheckBox.UseVisualStyleBackColor = true;
            this.TermsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(40, 394);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(106, 29);
            this.GoBackButton.TabIndex = 23;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Enabled = false;
            this.SignUpButton.Location = new System.Drawing.Point(151, 394);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(106, 29);
            this.SignUpButton.TabIndex = 24;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // PhoneCodesComboBox
            // 
            this.PhoneCodesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PhoneCodesComboBox.FormattingEnabled = true;
            this.PhoneCodesComboBox.Location = new System.Drawing.Point(111, 88);
            this.PhoneCodesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneCodesComboBox.Name = "PhoneCodesComboBox";
            this.PhoneCodesComboBox.Size = new System.Drawing.Size(55, 21);
            this.PhoneCodesComboBox.TabIndex = 25;
            // 
            // termsLinkLabel
            // 
            this.termsLinkLabel.AutoSize = true;
            this.termsLinkLabel.Location = new System.Drawing.Point(118, 376);
            this.termsLinkLabel.Name = "termsLinkLabel";
            this.termsLinkLabel.Size = new System.Drawing.Size(32, 13);
            this.termsLinkLabel.TabIndex = 26;
            this.termsLinkLabel.TabStop = true;
            this.termsLinkLabel.Text = "terms";
            this.termsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.termsLinkLabel_LinkClicked);
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(14, 138);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(66, 13);
            this.PostalCodeLabel.TabIndex = 27;
            this.PostalCodeLabel.Text = "Postal code:";
            // 
            // PostalCodeComboBox
            // 
            this.PostalCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostalCodeComboBox.FormattingEnabled = true;
            this.PostalCodeComboBox.Location = new System.Drawing.Point(109, 135);
            this.PostalCodeComboBox.Name = "PostalCodeComboBox";
            this.PostalCodeComboBox.Size = new System.Drawing.Size(184, 21);
            this.PostalCodeComboBox.TabIndex = 28;
            this.PostalCodeComboBox.SelectedValueChanged += new System.EventHandler(this.PostalCodeComboBox_SelectedValueChanged);
            // 
            // CitiesComboBox
            // 
            this.CitiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CitiesComboBox.FormattingEnabled = true;
            this.CitiesComboBox.Location = new System.Drawing.Point(109, 157);
            this.CitiesComboBox.Name = "CitiesComboBox";
            this.CitiesComboBox.Size = new System.Drawing.Size(184, 21);
            this.CitiesComboBox.TabIndex = 29;
            this.CitiesComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // CityComboBox
            // 
            this.CityComboBox.AutoSize = true;
            this.CityComboBox.Location = new System.Drawing.Point(14, 160);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(27, 13);
            this.CityComboBox.TabIndex = 30;
            this.CityComboBox.Text = "City:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(14, 182);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(38, 13);
            this.StreetLabel.TabIndex = 31;
            this.StreetLabel.Text = "Street:";
            // 
            // StreetComboBox
            // 
            this.StreetComboBox.FormattingEnabled = true;
            this.StreetComboBox.Location = new System.Drawing.Point(109, 179);
            this.StreetComboBox.Name = "StreetComboBox";
            this.StreetComboBox.Size = new System.Drawing.Size(184, 21);
            this.StreetComboBox.TabIndex = 32;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(109, 202);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.NumberTextBox.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Number:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(118, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 35;
            this.label13.Text = "Address";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContactLabel.Location = new System.Drawing.Point(118, 6);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(67, 18);
            this.ContactLabel.TabIndex = 36;
            this.ContactLabel.Text = "Contact";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(116, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 18);
            this.label14.TabIndex = 37;
            this.label14.Text = "Account";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 427);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.StreetComboBox);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.CitiesComboBox);
            this.Controls.Add(this.PostalCodeComboBox);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.termsLinkLabel);
            this.Controls.Add(this.PhoneCodesComboBox);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.TermsCheckBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RepeatPasswordBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PasswordMatchPB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CapitalLetterPB);
            this.Controls.Add(this.SpecialCharPB);
            this.Controls.Add(this.CharNumbersPB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.CharNumbersPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialCharPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapitalLetterPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordMatchPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox CharNumbersPB;
        private System.Windows.Forms.PictureBox CapitalLetterPB;
        private System.Windows.Forms.PictureBox SpecialCharPB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RepeatPasswordBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox PasswordMatchPB;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.CheckBox TermsCheckBox;
        private System.Windows.Forms.ComboBox PhoneCodesComboBox;
        private System.Windows.Forms.LinkLabel termsLinkLabel;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.ComboBox CitiesComboBox;
        private System.Windows.Forms.ComboBox PostalCodeComboBox;
        private System.Windows.Forms.Label CityComboBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.ComboBox StreetComboBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label label14;
    }
}