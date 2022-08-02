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
            this.components = new System.ComponentModel.Container();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharNumbersPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialCharPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapitalLetterPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordMatchPB)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(107, 11);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(184, 20);
            this.NameBox.TabIndex = 0;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(107, 32);
            this.SurnameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(184, 20);
            this.SurnameBox.TabIndex = 1;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(107, 53);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(184, 20);
            this.EmailBox.TabIndex = 2;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(165, 73);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(126, 20);
            this.PhoneBox.TabIndex = 3;
            this.PhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneBox_KeyPress);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(107, 94);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(184, 20);
            this.UsernameBox.TabIndex = 4;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(107, 115);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(184, 20);
            this.PasswordBox.TabIndex = 5;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // CharNumbersPB
            // 
            this.CharNumbersPB.Image = ((System.Drawing.Image)(resources.GetObject("CharNumbersPB.Image")));
            this.CharNumbersPB.Location = new System.Drawing.Point(13, 166);
            this.CharNumbersPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CharNumbersPB.Name = "CharNumbersPB";
            this.CharNumbersPB.Size = new System.Drawing.Size(16, 17);
            this.CharNumbersPB.TabIndex = 12;
            this.CharNumbersPB.TabStop = false;
            // 
            // SpecialCharPB
            // 
            this.SpecialCharPB.Image = ((System.Drawing.Image)(resources.GetObject("SpecialCharPB.Image")));
            this.SpecialCharPB.Location = new System.Drawing.Point(13, 181);
            this.SpecialCharPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpecialCharPB.Name = "SpecialCharPB";
            this.SpecialCharPB.Size = new System.Drawing.Size(16, 17);
            this.SpecialCharPB.TabIndex = 13;
            this.SpecialCharPB.TabStop = false;
            // 
            // CapitalLetterPB
            // 
            this.CapitalLetterPB.Image = ((System.Drawing.Image)(resources.GetObject("CapitalLetterPB.Image")));
            this.CapitalLetterPB.Location = new System.Drawing.Point(13, 196);
            this.CapitalLetterPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CapitalLetterPB.Name = "CapitalLetterPB";
            this.CapitalLetterPB.Size = new System.Drawing.Size(16, 17);
            this.CapitalLetterPB.TabIndex = 14;
            this.CapitalLetterPB.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password must contains at least 8 characters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Password must contains at least one special caracter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 196);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Password must contains at least one capital letter";
            // 
            // PasswordMatchPB
            // 
            this.PasswordMatchPB.Image = ((System.Drawing.Image)(resources.GetObject("PasswordMatchPB.Image")));
            this.PasswordMatchPB.Location = new System.Drawing.Point(13, 211);
            this.PasswordMatchPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordMatchPB.Name = "PasswordMatchPB";
            this.PasswordMatchPB.Size = new System.Drawing.Size(16, 17);
            this.PasswordMatchPB.TabIndex = 18;
            this.PasswordMatchPB.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 211);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Passwords have to match";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Repeat password:";
            // 
            // RepeatPasswordBox
            // 
            this.RepeatPasswordBox.Location = new System.Drawing.Point(107, 136);
            this.RepeatPasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RepeatPasswordBox.Name = "RepeatPasswordBox";
            this.RepeatPasswordBox.Size = new System.Drawing.Size(184, 20);
            this.RepeatPasswordBox.TabIndex = 20;
            this.RepeatPasswordBox.TextChanged += new System.EventHandler(this.RepeatPasswordBox_TextChanged);
            // 
            // TermsCheckBox
            // 
            this.TermsCheckBox.AutoSize = true;
            this.TermsCheckBox.Location = new System.Drawing.Point(14, 232);
            this.TermsCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TermsCheckBox.Name = "TermsCheckBox";
            this.TermsCheckBox.Size = new System.Drawing.Size(109, 17);
            this.TermsCheckBox.TabIndex = 22;
            this.TermsCheckBox.Text = "I accept the shop";
            this.TermsCheckBox.UseVisualStyleBackColor = true;
            this.TermsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(38, 251);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(106, 29);
            this.GoBackButton.TabIndex = 23;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Enabled = false;
            this.SignUpButton.Location = new System.Drawing.Point(149, 251);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.PhoneCodesComboBox.Location = new System.Drawing.Point(108, 73);
            this.PhoneCodesComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhoneCodesComboBox.Name = "PhoneCodesComboBox";
            this.PhoneCodesComboBox.Size = new System.Drawing.Size(55, 21);
            this.PhoneCodesComboBox.TabIndex = 25;
            // 
            // termsLinkLabel
            // 
            this.termsLinkLabel.AutoSize = true;
            this.termsLinkLabel.Location = new System.Drawing.Point(116, 233);
            this.termsLinkLabel.Name = "termsLinkLabel";
            this.termsLinkLabel.Size = new System.Drawing.Size(32, 13);
            this.termsLinkLabel.TabIndex = 26;
            this.termsLinkLabel.TabStop = true;
            this.termsLinkLabel.Text = "terms";
            this.termsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.termsLinkLabel_LinkClicked);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 290);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
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
    }
}