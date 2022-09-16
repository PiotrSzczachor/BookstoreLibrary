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
    public partial class AdminPanelForm : Form
    {
        User currentlyLoggedUser;
        public AdminPanelForm(User user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            Initializer initializer = new Initializer();
            initializer.initInfoLabel(InfoLabel, user.Username);
            InfoLabel.Left = (this.Width - InfoLabel.Width) / 2;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BooksPanelForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UsersManagementForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void StoresButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StoresMapForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountInfoForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
