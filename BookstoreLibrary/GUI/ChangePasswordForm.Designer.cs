namespace BookstoreLibrary.GUI
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PasswordMatchPB = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CapitalLetterPB = new System.Windows.Forms.PictureBox();
            this.SpecialCharPB = new System.Windows.Forms.PictureBox();
            this.CharNumbersPB = new System.Windows.Forms.PictureBox();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.HideShowOldPassword = new System.Windows.Forms.PictureBox();
            this.OldPasswordBox = new System.Windows.Forms.TextBox();
            this.HideShowNewPassword = new System.Windows.Forms.PictureBox();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.HideShowRepeatPassword = new System.Windows.Forms.PictureBox();
            this.RepeatPasswordBox = new System.Windows.Forms.TextBox();
            this.Checker = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordMatchPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapitalLetterPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialCharPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharNumbersPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideShowOldPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideShowNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideShowRepeatPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Location = new System.Drawing.Point(12, 9);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(74, 13);
            this.OldPasswordLabel.TabIndex = 3;
            this.OldPasswordLabel.Text = "Old password:";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(12, 35);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(80, 13);
            this.NewPasswordLabel.TabIndex = 4;
            this.NewPasswordLabel.Text = "New password:";
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(12, 61);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(93, 13);
            this.RepeatPasswordLabel.TabIndex = 5;
            this.RepeatPasswordLabel.Text = "Repeat password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Passwords have to match";
            // 
            // PasswordMatchPB
            // 
            this.PasswordMatchPB.Image = ((System.Drawing.Image)(resources.GetObject("PasswordMatchPB.Image")));
            this.PasswordMatchPB.Location = new System.Drawing.Point(13, 130);
            this.PasswordMatchPB.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordMatchPB.Name = "PasswordMatchPB";
            this.PasswordMatchPB.Size = new System.Drawing.Size(16, 17);
            this.PasswordMatchPB.TabIndex = 26;
            this.PasswordMatchPB.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Password must contains at least one capital letter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Password must contains at least one special caracter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Password must contains at least 8 characters";
            // 
            // CapitalLetterPB
            // 
            this.CapitalLetterPB.Image = ((System.Drawing.Image)(resources.GetObject("CapitalLetterPB.Image")));
            this.CapitalLetterPB.Location = new System.Drawing.Point(13, 115);
            this.CapitalLetterPB.Margin = new System.Windows.Forms.Padding(2);
            this.CapitalLetterPB.Name = "CapitalLetterPB";
            this.CapitalLetterPB.Size = new System.Drawing.Size(16, 17);
            this.CapitalLetterPB.TabIndex = 22;
            this.CapitalLetterPB.TabStop = false;
            // 
            // SpecialCharPB
            // 
            this.SpecialCharPB.Image = ((System.Drawing.Image)(resources.GetObject("SpecialCharPB.Image")));
            this.SpecialCharPB.Location = new System.Drawing.Point(13, 100);
            this.SpecialCharPB.Margin = new System.Windows.Forms.Padding(2);
            this.SpecialCharPB.Name = "SpecialCharPB";
            this.SpecialCharPB.Size = new System.Drawing.Size(16, 17);
            this.SpecialCharPB.TabIndex = 21;
            this.SpecialCharPB.TabStop = false;
            // 
            // CharNumbersPB
            // 
            this.CharNumbersPB.Image = ((System.Drawing.Image)(resources.GetObject("CharNumbersPB.Image")));
            this.CharNumbersPB.Location = new System.Drawing.Point(13, 85);
            this.CharNumbersPB.Margin = new System.Windows.Forms.Padding(2);
            this.CharNumbersPB.Name = "CharNumbersPB";
            this.CharNumbersPB.Size = new System.Drawing.Size(16, 17);
            this.CharNumbersPB.TabIndex = 20;
            this.CharNumbersPB.TabStop = false;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Enabled = false;
            this.ChangePasswordButton.Location = new System.Drawing.Point(181, 156);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(106, 29);
            this.ChangePasswordButton.TabIndex = 29;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(70, 156);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(106, 29);
            this.GoBackButton.TabIndex = 28;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // HideShowOldPassword
            // 
            this.HideShowOldPassword.Image = ((System.Drawing.Image)(resources.GetObject("HideShowOldPassword.Image")));
            this.HideShowOldPassword.Location = new System.Drawing.Point(302, 8);
            this.HideShowOldPassword.Margin = new System.Windows.Forms.Padding(2);
            this.HideShowOldPassword.Name = "HideShowOldPassword";
            this.HideShowOldPassword.Size = new System.Drawing.Size(18, 15);
            this.HideShowOldPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HideShowOldPassword.TabIndex = 31;
            this.HideShowOldPassword.TabStop = false;
            this.HideShowOldPassword.Click += new System.EventHandler(this.HideShowOldPassword_Click);
            // 
            // OldPasswordBox
            // 
            this.OldPasswordBox.Location = new System.Drawing.Point(110, 6);
            this.OldPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.OldPasswordBox.Name = "OldPasswordBox";
            this.OldPasswordBox.Size = new System.Drawing.Size(211, 20);
            this.OldPasswordBox.TabIndex = 30;
            this.OldPasswordBox.UseSystemPasswordChar = true;
            // 
            // HideShowNewPassword
            // 
            this.HideShowNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("HideShowNewPassword.Image")));
            this.HideShowNewPassword.Location = new System.Drawing.Point(301, 34);
            this.HideShowNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.HideShowNewPassword.Name = "HideShowNewPassword";
            this.HideShowNewPassword.Size = new System.Drawing.Size(18, 15);
            this.HideShowNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HideShowNewPassword.TabIndex = 33;
            this.HideShowNewPassword.TabStop = false;
            this.HideShowNewPassword.Click += new System.EventHandler(this.HideShowNewPassword_Click);
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Location = new System.Drawing.Point(109, 32);
            this.NewPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.Size = new System.Drawing.Size(211, 20);
            this.NewPasswordBox.TabIndex = 32;
            this.NewPasswordBox.UseSystemPasswordChar = true;
            this.NewPasswordBox.TextChanged += new System.EventHandler(this.NewPasswordBox_TextChanged);
            // 
            // HideShowRepeatPassword
            // 
            this.HideShowRepeatPassword.Image = ((System.Drawing.Image)(resources.GetObject("HideShowRepeatPassword.Image")));
            this.HideShowRepeatPassword.Location = new System.Drawing.Point(302, 60);
            this.HideShowRepeatPassword.Margin = new System.Windows.Forms.Padding(2);
            this.HideShowRepeatPassword.Name = "HideShowRepeatPassword";
            this.HideShowRepeatPassword.Size = new System.Drawing.Size(18, 15);
            this.HideShowRepeatPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HideShowRepeatPassword.TabIndex = 35;
            this.HideShowRepeatPassword.TabStop = false;
            this.HideShowRepeatPassword.Click += new System.EventHandler(this.HideShowRepeatPassword_Click);
            // 
            // RepeatPasswordBox
            // 
            this.RepeatPasswordBox.Location = new System.Drawing.Point(110, 58);
            this.RepeatPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.RepeatPasswordBox.Name = "RepeatPasswordBox";
            this.RepeatPasswordBox.Size = new System.Drawing.Size(211, 20);
            this.RepeatPasswordBox.TabIndex = 34;
            this.RepeatPasswordBox.UseSystemPasswordChar = true;
            this.RepeatPasswordBox.TextChanged += new System.EventHandler(this.RepeatPasswordBox_TextChanged);
            // 
            // Checker
            // 
            this.Checker.Tick += new System.EventHandler(this.Checker_Tick);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 196);
            this.Controls.Add(this.HideShowRepeatPassword);
            this.Controls.Add(this.RepeatPasswordBox);
            this.Controls.Add(this.HideShowNewPassword);
            this.Controls.Add(this.NewPasswordBox);
            this.Controls.Add(this.HideShowOldPassword);
            this.Controls.Add(this.OldPasswordBox);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PasswordMatchPB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CapitalLetterPB);
            this.Controls.Add(this.SpecialCharPB);
            this.Controls.Add(this.CharNumbersPB);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.OldPasswordLabel);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordMatchPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapitalLetterPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialCharPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharNumbersPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideShowOldPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideShowNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideShowRepeatPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label RepeatPasswordLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox PasswordMatchPB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox CapitalLetterPB;
        private System.Windows.Forms.PictureBox SpecialCharPB;
        private System.Windows.Forms.PictureBox CharNumbersPB;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.PictureBox HideShowOldPassword;
        private System.Windows.Forms.TextBox OldPasswordBox;
        private System.Windows.Forms.PictureBox HideShowNewPassword;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.PictureBox HideShowRepeatPassword;
        private System.Windows.Forms.TextBox RepeatPasswordBox;
        private System.Windows.Forms.Timer Checker;
    }
}