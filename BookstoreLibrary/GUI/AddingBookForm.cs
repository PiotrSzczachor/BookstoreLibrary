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
    public partial class AddingBookForm : Form
    {
        User currentlyLoggedUser;
        public AddingBookForm(User user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            Initializer initializer = new Initializer();
            initializer.initAddingBookComboBoxes(AuthorComboBox, TypeComboBox, PublisherComboBox, PublishYearComboBox, CurrencyComboBox, CurrencyFlagPictureBox);
        }

        private void BookForSaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BookForSaleCheckBox.Checked)
            {
                PriceBox.Enabled = true;
                CurrencyComboBox.Enabled = true;
            } else
            {
                PriceBox.Enabled = false;
                CurrencyComboBox.Enabled = false;
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BooksPanelForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void CurrencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddingBookLogic addingBookLogic = new AddingBookLogic();
            addingBookLogic.changeFlagPicture(CurrencyComboBox.Text, CurrencyFlagPictureBox);
        }
    }
}
