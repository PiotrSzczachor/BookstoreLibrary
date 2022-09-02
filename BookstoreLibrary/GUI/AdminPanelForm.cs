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
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }
    }
}
