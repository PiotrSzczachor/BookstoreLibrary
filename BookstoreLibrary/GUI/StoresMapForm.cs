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
using GMap.NET;

namespace BookstoreLibrary.GUI
{
    public partial class StoresMapForm : Form
    {
        User currentlyLoggedUser;
        public StoresMapForm(User user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (currentlyLoggedUser.Role.IsAdmin)
            {
                new AdminPanelForm(currentlyLoggedUser).ShowDialog();
            } else
            {
                if (currentlyLoggedUser.Role.IsUser)
                {
                    new UserPanelForm(currentlyLoggedUser).ShowDialog();
                } else if (currentlyLoggedUser.Role.IsSeller)
                {
                    new SellerPanelForm(currentlyLoggedUser).ShowDialog();
                }
            }
            this.Close();
        }

        private void StoresMap_Load(object sender, EventArgs e)
        {
            StoresMap.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            StoresMap.SetPositionByKeywords("Poland");
            StoresMap.Zoom = 5;
            StoresMap.ShowCenter = false;
            Initializer initializer = new Initializer();
            initializer.initStoreMarkersOnMap(StoresMap);
        }

        private void AddStoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddingStoreForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
