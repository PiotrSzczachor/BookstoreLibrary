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
    }
}
