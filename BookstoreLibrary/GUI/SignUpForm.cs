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
        private bool isPasswordValid;
        public SignUpForm()
        {
            InitializeComponent();
            isPasswordValid = false;
            Initializer initializer = new Initializer();
            initializer.initPhoneCodesComboBox(PhoneCodesComboBox);
            initializer.initPostalCodes(PostalCodeComboBox);
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
            string phoneNumber = PhoneCodesComboBox.Text + PhoneBox.Text;
            signUpLogic.signUp(NameBox.Text, SurnameBox.Text, EmailBox.Text, PhoneBox.Text, UsernameBox.Text, PasswordBox.Text, RepeatPasswordBox.Text,
                               isPasswordValid, StreetComboBox.Text, NumberTextBox.Text, CitiesComboBox.Text, PostalCodeComboBox.Text);
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

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void PostalCodeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Initializer initializer = new Initializer();
            initializer.initCities(CitiesComboBox, PostalCodeComboBox.Text);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }
    }
}
