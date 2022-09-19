using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;
using BookstoreLibrary.Logic;

namespace BookstoreLibrary.GUI
{
    public partial class ChangePasswordForm : Form
    {
        User currentlyLoggedUser;
        bool isNewPasswordValid;
        string path;
        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            Checker.Enabled = true;
            Checker.Start();
            string startupPath = Environment.CurrentDirectory;
            startupPath = startupPath.Replace(@"\bin\Debug", "");
            path = Path.Combine(startupPath, @"Images\");
        }

        private void NewPasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordValidator passwordValidator = new PasswordValidator();
            isNewPasswordValid = passwordValidator.validatePassword(NewPasswordBox.Text, RepeatPasswordBox.Text, CharNumbersPB, SpecialCharPB, CapitalLetterPB, PasswordMatchPB);
        }

        private void RepeatPasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordValidator passwordValidator = new PasswordValidator();
            isNewPasswordValid = passwordValidator.validatePassword(NewPasswordBox.Text, RepeatPasswordBox.Text, CharNumbersPB, SpecialCharPB, CapitalLetterPB, PasswordMatchPB);
        }

        private void Checker_Tick(object sender, EventArgs e)
        {
            if (isNewPasswordValid && !string.IsNullOrEmpty(OldPasswordBox.Text))
            {
                ChangePasswordButton.Enabled = true;
            } else
            {
                ChangePasswordButton.Enabled = false;
            }
        }

        private void HideShowOldPassword_Click(object sender, EventArgs e)
        {
            
            PasswordValidator passwordValidator = new PasswordValidator();
            passwordValidator.changePasswordVisible(HideShowOldPassword, OldPasswordBox, path);
        }

        private void HideShowNewPassword_Click(object sender, EventArgs e)
        {
            PasswordValidator passwordValidator = new PasswordValidator();
            passwordValidator.changePasswordVisible(HideShowNewPassword, NewPasswordBox, path);
        }

        private void HideShowRepeatPassword_Click(object sender, EventArgs e)
        {
            PasswordValidator passwordValidator = new PasswordValidator();
            passwordValidator.changePasswordVisible(HideShowRepeatPassword, RepeatPasswordBox, path);
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            UsersManager usersManager = new UsersManager();
            usersManager.changePassword(currentlyLoggedUser, OldPasswordBox.Text, NewPasswordBox.Text);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountInfoForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
