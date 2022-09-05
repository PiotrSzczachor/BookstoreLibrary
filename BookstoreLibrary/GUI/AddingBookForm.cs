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

        private void PublishYearComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleOnlyDigits(e, PublishYearComboBox.Text);
        }

        private void PageNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleOnlyDigits(e, PageNumberBox.Text);
        }

        private void QuantityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleOnlyDigits(e, QuantityBox.Text);
        }

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleOnlyFloatNumbers(e, PriceBox.Text);
        }

        private void handleOnlyFloatNumbers(KeyPressEventArgs e, string text)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            } 
            else
            {
                if (e.KeyChar == ',' && (text.Count(ch => ch == ',') > 0 || text.Length == 0))
                {
                    e.Handled = true;
                }
            }
        }

        private void handleOnlyDigits(KeyPressEventArgs e, string text)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddingBookLogic addingBookLogic = new AddingBookLogic();
            if (BookForSaleCheckBox.Checked)
            {
                addingBookLogic.addBookForSale(TitleBox.Text, AuthorComboBox.Text, TypeComboBox.Text,
                                               PublisherComboBox.Text, PublishYearComboBox.Text, PageNumberBox.Text,
                                               QuantityBox.Text, PriceBox.Text, CurrencyComboBox.Text);
            } else
            {
                addingBookLogic.addBookToBorrow(TitleBox.Text, AuthorComboBox.Text, TypeComboBox.Text,
                                               PublisherComboBox.Text, PublishYearComboBox.Text, PageNumberBox.Text,
                                               QuantityBox.Text);
            }
            
        }
    }
}
