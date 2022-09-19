using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;
using BookstoreLibrary.Logic;

namespace BookstoreLibrary.GUI
{
    public partial class AccountInfoForm : Form
    {
        User currentlyLoggedUser;
        int userToCheckId;
        string initName;
        string initSurname;
        string initUsername;
        string initEmail;
        string initCountryCode;
        string initPhoneNumber;
        string initRole;
        bool emailChanged;
        bool usernameChanged;
        public AccountInfoForm(User user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            userToCheckId = user.Id;
            Initializer initializer = new Initializer();
            initializer.initPhoneCodesComboBox(PhoneCodesComboBox);
            initializer.initUserInfo(userToCheckId, NameBox, SurnameBox, UsernameBox, EmailBox, PhoneCodesComboBox, PhoneBox);
            string[] roles = { "Admin", "User", "Seller" };
            foreach (string role in roles)
            {
                RolesComboBox.Items.Add(role);
            }
            RolesComboBox.Text = currentlyLoggedUser.Role.Name;
            initName = NameBox.Text;
            initSurname = SurnameBox.Text;
            initUsername = UsernameBox.Text;
            initEmail = EmailBox.Text;
            initCountryCode = PhoneCodesComboBox.Text;
            initPhoneNumber = PhoneBox.Text;
            initRole = RolesComboBox.Text;
            ChangesChecker.Enabled = true;
            ChangesChecker.Start();
            if (currentlyLoggedUser.Role.Name != "Admin")
            {
                RoleLabel.Visible = false;
                RolesComboBox.Visible = false;
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (currentlyLoggedUser.Role.Name == "Admin")
            {
                new AdminPanelForm(currentlyLoggedUser).ShowDialog();
            } else
            {
                if (currentlyLoggedUser.Role.Name == "User")
                {
                    new UserPanelForm(currentlyLoggedUser).ShowDialog();
                } else
                {
                    if (currentlyLoggedUser.Role.Name == "Seller")
                    {
                        new SellerPanelForm(currentlyLoggedUser).ShowDialog();
                    }
                }
            }
            this.Close();
        }

        private void ShowAddressButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddressInfoForm(currentlyLoggedUser, currentlyLoggedUser, true).ShowDialog();
            this.Close();
        }

        private void AllowEditsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllowEditsCheckBox.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c is TextBox || c is ComboBox) { c.Enabled = true; }
                }
            } else
            {
                foreach(Control c in Controls)
                {
                    if (!(c is Label))
                    {
                        c.Enabled = false;
                    }
                }
                AllowEditsCheckBox.Enabled = true;
                GoBackButton.Enabled = true;
                ShowAddressButton.Enabled = true;
                ChangePasswordButton.Enabled = true;
            }
        }

        private void ChangesChecker_Tick(object sender, EventArgs e)
        {
            List<string> initValues = new List<string> { initName, initSurname, initUsername, initEmail, initCountryCode, initPhoneNumber, initRole };
            List<string> values = new List<string> { NameBox.Text, SurnameBox.Text, UsernameBox.Text, EmailBox.Text, PhoneCodesComboBox.Text, PhoneBox.Text, RolesComboBox.Text };
            bool emptyValues = false;
            bool valuesChanged = false;
            for (int i = 0; i < values.Count; i++)
            {
                if (string.IsNullOrEmpty(values[i]))
                {
                    emptyValues = true;
                }
                if (values[i] != initValues[i])
                {
                    valuesChanged = true;
                }
            }
            if (initEmail != EmailBox.Text)
            {
                emailChanged = true;
            }
            else
            {
                emailChanged = false;
            }
            if (initUsername != UsernameBox.Text)
            {
                usernameChanged = true;
            }
            else
            {
                usernameChanged = false;
            }
            if (!emptyValues && valuesChanged)
            {
                SaveButton.Enabled = true;
            }
            else
            {
                SaveButton.Enabled = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UsersManager usersManager = new UsersManager();
            usersManager.editUser(emailChanged, usernameChanged, currentlyLoggedUser.Id, currentlyLoggedUser, NameBox, SurnameBox, UsernameBox, EmailBox, PhoneCodesComboBox, PhoneBox, true);
            if (currentlyLoggedUser.Role.Name != "Admin")
            {
                usersManager.changeRole(currentlyLoggedUser.Username, RolesComboBox.Text, true, currentlyLoggedUser);
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePasswordForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
