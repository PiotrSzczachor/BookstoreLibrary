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
    public partial class UserHistoryForm : Form
    {
        User currentlyLoggedUser;
        string userToCheck;
        public UserHistoryForm(User currUser, string toCheck)
        {
            InitializeComponent();
            currentlyLoggedUser = currUser;
            userToCheck = toCheck;
            Initializer initializer = new Initializer();
            initializer.initHistoryTable(historyTable, userToCheck, UsernameHistoryLabel);
            UsernameHistoryLabel.Left = (this.Width - UsernameHistoryLabel.Width) / 2;
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryFilter filter = new HistoryFilter();
            filter.filterBy("Borrow", historyTable, userToCheck, UsernameHistoryLabel);
            UsernameHistoryLabel.Left = (this.Width - UsernameHistoryLabel.Width) / 2;
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryFilter filter = new HistoryFilter();
            filter.filterBy("Buy", historyTable, userToCheck, UsernameHistoryLabel);
            UsernameHistoryLabel.Left = (this.Width - UsernameHistoryLabel.Width) / 2;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryFilter filter = new HistoryFilter();
            filter.filterBy("Return", historyTable, userToCheck, UsernameHistoryLabel);
            UsernameHistoryLabel.Left = (this.Width - UsernameHistoryLabel.Width) / 2;
        }

        private void allActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initializer initializer = new Initializer();
            initializer.initHistoryTable(historyTable, userToCheck, UsernameHistoryLabel);
            UsernameHistoryLabel.Left = (this.Width - UsernameHistoryLabel.Width) / 2;
        }
    }
}
