using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.GUI;
using BookstoreLibrary.Logic;
using BookstoreLibrary.Entities;
using System.IO;

namespace BookstoreLibrary
{
    public partial class LoginForm : Form
    {
        User currentlyLoggedUser;
        string path;
        public LoginForm()
        {
            InitializeComponent();
            Initializer initializer = new Initializer();
            initializer.initRolesIfDbIsEmpty();
            string startupPath = Environment.CurrentDirectory;
            startupPath = startupPath.Replace(@"\bin\Debug", "");
            path = Path.Combine(startupPath, @"Images\");
        }

        private void ShowPasswordPictureBox_Click(object sender, EventArgs e)
        {
            PasswordValidator passwordValidator = new PasswordValidator();
            passwordValidator.changePasswordVisible(HideShowPassword, PasswordBox, path);
        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpForm().ShowDialog();
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LogInLogic logInLogic = new LogInLogic();
            logInLogic.logIn(UsernameBox.Text, PasswordBox.Text, this);
        }
    }
}
