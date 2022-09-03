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
    public partial class AddressInfoForm : Form
    {
        User currentlyLoggedUser;
        User userToCheck;
        string initStreet;
        string initNumber;
        string initCity;
        string initPostalCode;
        public AddressInfoForm(User currUser, User toCheck)
        {
            InitializeComponent();
            currentlyLoggedUser = currUser;
            userToCheck = toCheck;
            Initializer initializer = new Initializer();
            initializer.initAddressInfo(StreetBox, NumberTextBox, CityBox, PostalCodeBox, toCheck);
            initStreet = StreetBox.Text;
            initNumber = NumberTextBox.Text;
            initCity = CityBox.Text;
            initPostalCode = PostalCodeBox.Text;
            ChangesChecker.Enabled = true;
            ChangesChecker.Start();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanelForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void EditCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                StreetBox.Enabled = true;
                NumberTextBox.Enabled = true;
                CityBox.Enabled = true;
                PostalCodeBox.Enabled = true;
            } else
            {
                StreetBox.Enabled = false;
                NumberTextBox.Enabled = false;
                CityBox.Enabled = false;
                PostalCodeBox.Enabled = false;
            }
        }

        private void ChangesChecker_Tick(object sender, EventArgs e)
        {
            if (StreetBox.Text != initStreet || CityBox.Text != initCity ||
                NumberTextBox.Text != initNumber || PostalCodeBox.Text != initPostalCode)
            {
                SaveButton.Enabled = true;
            } else
            {
                SaveButton.Enabled = false;  
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UsersManager usersManager = new UsersManager();
            bool wasEdited = usersManager.editAdress(userToCheck, StreetBox.Text, NumberTextBox.Text, CityBox.Text, PostalCodeBox.Text);
            if (wasEdited)
            {
                initStreet = StreetBox.Text;
                initCity = CityBox.Text;
                initNumber = NumberTextBox.Text;
                initPostalCode = PostalCodeBox.Text;
            }
        }
    }
}
