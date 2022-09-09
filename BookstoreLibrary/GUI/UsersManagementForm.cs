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
    public partial class UsersManagementForm : Form
    {
        User currentlyLoggedUser;
        public UsersManagementForm(User user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            Initializer initializer = new Initializer();
            initializer.initUsersTable(UsersTable, UsersTypeLabel);
            UsersTypeLabel.Left = (this.Width - UsersTypeLabel.Width) / 2;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanelForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void ShowAddressButton_Click(object sender, EventArgs e)
        {
            if (UsersTable.SelectedCells.Count > 0)
            {
                int selectedrowindex = UsersTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = UsersTable.Rows[selectedrowindex];
                string username = Convert.ToString(selectedRow.Cells["Username"].Value);
                using (var db = new BookstoreLibContext())
                {
                    User user = db.Users.FirstOrDefault(u => u.Username == username);
                    if (user != null)
                    {
                        this.Hide();
                        new AddressInfoForm(currentlyLoggedUser, user).ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void ShowHistoryButton_Click(object sender, EventArgs e)
        {
            if (UsersTable.SelectedCells.Count > 0)
            {
                int selectedrowindex = UsersTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = UsersTable.Rows[selectedrowindex];
                string userToCheck = Convert.ToString(selectedRow.Cells["Username"].Value);
                this.Hide();
                new UserHistoryForm(currentlyLoggedUser, userToCheck).ShowDialog();
                this.Close();
            }
            
        }
    }
}
