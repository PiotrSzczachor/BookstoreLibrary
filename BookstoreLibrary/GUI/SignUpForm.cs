using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Logic;
using EmailSender;


namespace BookstoreLibrary.GUI
{
    public partial class SignUpForm : Form
    {
        private bool isPasswordValid = false;
        public SignUpForm()
        {
            InitializeComponent();
            Initializer initializer = new Initializer();
            initializer.initPhoneCodesComboBox(PhoneCodesComboBox);
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordValidator passwordValidator = new PasswordValidator();
            isPasswordValid = passwordValidator.validatePassword(PasswordBox.Text, RepeatPasswordBox.Text, CharNumbersPB, SpecialCharPB, CapitalLetterPB, PasswordMatchPB);
        }

        private void RepeatPasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordValidator passwordValidator = new PasswordValidator();
            isPasswordValid = passwordValidator.validatePassword(PasswordBox.Text, RepeatPasswordBox.Text, CharNumbersPB, SpecialCharPB, CapitalLetterPB, PasswordMatchPB);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpLogic signUpLogic = new SignUpLogic();
            //signUpLogic.signUp();
            Email email = new Email();
            string body = "Hello " + NameBox.Text + "!\nYour account in out Bookstore&Library is now active. You can now login using your username: " + UsernameBox.Text;
            email.sendEmail(EmailBox.Text, body, "Bookstore&Library confirmation email");
        }

        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(TermsCheckBox.Checked)
            SignUpButton.Enabled = true;
            else
            SignUpButton.Enabled = false;
        }

        private void termsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             System.Diagnostics.Process.Start("https://termly.io/products/terms-and-conditions-generator/");
        }

    }
}
