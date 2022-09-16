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
    public partial class ChangeRoleForm : Form
    {
        User currentlyLoggedUser;
        int userToEditId;
        string initRole;
        public ChangeRoleForm(User user, int id)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            userToEditId = id;
            Initializer initializer = new Initializer();
            initializer.initChangeRoleForm(userToEditId, UsernameBox, RolesComboBox);
            initRole = RolesComboBox.Text;
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
            bool roleChanged = false;
            if (initRole != RolesComboBox.Text)
            {
                roleChanged = true;
            } else
            {
                roleChanged = false;
            }
            if (roleChanged)
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
            usersManager.changeRole(UsernameBox.Text, RolesComboBox.Text);
        }
    }
}
