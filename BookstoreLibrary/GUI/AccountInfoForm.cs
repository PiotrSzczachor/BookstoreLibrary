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
            User user;
            using (var db = new BookstoreLibContext())
            {
                user  = db.Users.FirstOrDefault(x => x.Id == userToCheckId);
            }
            this.Hide();
            new AddressInfoForm(currentlyLoggedUser, user).ShowDialog();
            this.Close();
        }
    }
}
