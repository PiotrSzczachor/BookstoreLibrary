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

namespace BookstoreLibrary.GUI
{
    public partial class SellerPanelForm : Form
    {
        User currentlyLoggedUser;
        public SellerPanelForm(User user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
        }
    }
}
