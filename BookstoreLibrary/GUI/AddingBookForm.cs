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
    }
}
