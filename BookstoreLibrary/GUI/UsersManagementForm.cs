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
        }
    }
}
