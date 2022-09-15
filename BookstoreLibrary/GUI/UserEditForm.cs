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
    public partial class UserEditForm : Form
    {
        User currentlyLoggedUser;
        int userToEditId;
        string initName;
        string initSurname;
        string initUsername;
        string initEmail;
        string initCountryCode;
        string initPhoneNumber;

        public UserEditForm(User user, int id)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            userToEditId = id;
            Initializer initializer = new Initializer();
            initializer.initPhoneCodesComboBox(PhoneCodesComboBox);
            initializer.initUserInfo(userToEditId, NameBox, SurnameBox, UsernameBox, EmailBox, PhoneCodesComboBox, PhoneBox);
            initName = NameBox.Text;
            initSurname = SurnameBox.Text;
            initUsername = UsernameBox.Text;
            initEmail = EmailBox.Text;
            initCountryCode = PhoneCodesComboBox.Text;
            initPhoneNumber = PhoneBox.Text;
            ChangesChecker.Enabled = true;
            ChangesChecker.Start();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UsersManagementForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void ChangesChecker_Tick(object sender, EventArgs e)
        {
            List<string> initValues = new List<string> { initName, initSurname, initUsername, initEmail, initCountryCode, initPhoneNumber };
            List<string> values = new List<string> { NameBox.Text, SurnameBox.Text, UsernameBox.Text, EmailBox.Text, PhoneCodesComboBox.Text, PhoneBox.Text };
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
            usersManager.editUser(userToEditId, currentlyLoggedUser, NameBox, SurnameBox, UsernameBox, EmailBox, PhoneCodesComboBox, PhoneBox);
        }
    }
}
