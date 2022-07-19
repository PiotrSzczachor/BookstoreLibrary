﻿namespace BookstoreLibrary
{
    partial class LoginForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SigninButton = new System.Windows.Forms.Button();
            this.ContinueAsGuestButton = new System.Windows.Forms.Button();
            this.HideShowPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HideShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(25, 136);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(147, 43);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(21, 33);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(151, 20);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username or e-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(184, 30);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(294, 26);
            this.UsernameBox.TabIndex = 5;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(184, 68);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(294, 26);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // SigninButton
            // 
            this.SigninButton.Location = new System.Drawing.Point(178, 136);
            this.SigninButton.Name = "SigninButton";
            this.SigninButton.Size = new System.Drawing.Size(147, 43);
            this.SigninButton.TabIndex = 7;
            this.SigninButton.Text = "Sign in";
            this.SigninButton.UseVisualStyleBackColor = true;
            this.SigninButton.Click += new System.EventHandler(this.SigninButton_Click);
            // 
            // ContinueAsGuestButton
            // 
            this.ContinueAsGuestButton.Location = new System.Drawing.Point(331, 136);
            this.ContinueAsGuestButton.Name = "ContinueAsGuestButton";
            this.ContinueAsGuestButton.Size = new System.Drawing.Size(147, 43);
            this.ContinueAsGuestButton.TabIndex = 8;
            this.ContinueAsGuestButton.Text = "Continue as guest";
            this.ContinueAsGuestButton.UseVisualStyleBackColor = true;
            // 
            // HideShowPassword
            // 
            this.HideShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("HideShowPassword.Image")));
            this.HideShowPassword.Location = new System.Drawing.Point(453, 71);
            this.HideShowPassword.Name = "HideShowPassword";
            this.HideShowPassword.Size = new System.Drawing.Size(25, 23);
            this.HideShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HideShowPassword.TabIndex = 9;
            this.HideShowPassword.TabStop = false;
            this.HideShowPassword.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 201);
            this.Controls.Add(this.HideShowPassword);
            this.Controls.Add(this.ContinueAsGuestButton);
            this.Controls.Add(this.SigninButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HideShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button SigninButton;
        private System.Windows.Forms.Button ContinueAsGuestButton;
        private System.Windows.Forms.PictureBox HideShowPassword;
    }
}
