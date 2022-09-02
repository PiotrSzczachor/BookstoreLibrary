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

namespace BookstoreLibrary
{
    public partial class LoginForm : Form
    {
        User currentlyLoggedUser;
        public LoginForm()
        {
            InitializeComponent();
            Initializer initializer = new Initializer();
            initializer.initRolesIfDbIsEmpty();
        }

        private void ShowPasswordPictureBox_Click(object sender, EventArgs e)
        {
            if (PasswordBox.UseSystemPasswordChar)
            {
                HideShowPassword.Image = Image.FromFile(@"C:\Users\piotr\source\repos\BookstoreLibrary\BookstoreLibrary\Images\Hide.png");
                PasswordBox.UseSystemPasswordChar = false;
            } else
            {
                HideShowPassword.Image = Image.FromFile(@"C:\Users\piotr\source\repos\BookstoreLibrary\BookstoreLibrary\Images\Show.png");
                PasswordBox.UseSystemPasswordChar = true;
            }
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
