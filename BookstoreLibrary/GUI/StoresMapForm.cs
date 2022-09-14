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
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

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
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            StoresMap.SetPositionByKeywords("Poland");
            StoresMap.Zoom = 5;
            StoresMap.ShowCenter = false;
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(new GMap.NET.PointLatLng(50.067658, 19.946017), GMarkerGoogleType.red);
            markers.Markers.Add(marker);
            StoresMap.Overlays.Add(markers);
        }

        private void AddStoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddingStoreForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }
    }
}
