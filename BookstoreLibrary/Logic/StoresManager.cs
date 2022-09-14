using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;
using Geocoding;
using Geocoding.Microsoft;
using GoogleMaps.LocationServices;
using GMap.NET.WindowsForms;

namespace BookstoreLibrary.Logic
{
    public class StoresManager
    {
        public async void addStore(string name, string openingHour, string openingMinute, string closingHour, string closingMinute,
                             List<string> openingDays, string street, string number, string city, string postalCode)
        {
            List<string> values = new List<string> { name, openingHour, openingMinute, closingHour, closingMinute, street, number, city, postalCode };
            bool allValuesValid = true;
            if (openingDays.Count < 0)
            {
                allValuesValid = false;
            }
            foreach (string value in values)
            {
                if (string.IsNullOrEmpty(value))
                {
                    allValuesValid = false;
                }
            }
            if (allValuesValid)
            {
                using (var db = new BookstoreLibContext())
                {
                    BookstoreLibrary.Entities.Address storeAddress = new BookstoreLibrary.Entities.Address { Street = street, City = city, PostalCode = postalCode, Number = number };
                    db.Addresses.Add(storeAddress);
                    db.SaveChanges();
                    var address = street + " "  + number + ", " + city + ", " + postalCode;
                    IGeocoder geocoder = new BingMapsGeocoder("AiePEZC3a_AhN_9YAvmhZ55zw296iW_-ZEWUwf-cHyPpecM6AnOL6bLCDz9qQwnP");
                    IEnumerable<Geocoding.Address> coordinates = await geocoder.GeocodeAsync(address);
                    double latitude = coordinates.First().Coordinates.Latitude;
                    double longitude = coordinates.First().Coordinates.Longitude;
                    string openingHours = openingHour + ":" + openingMinute;
                    string closingHours = closingHour + ":" + closingMinute;
                    string openingDaysStr = "";
                    foreach (string day in openingDays)
                    {
                        openingDaysStr += day + ",";
                    }
                    openingDaysStr = openingDaysStr.Remove(openingDaysStr.Length - 1, 1);
                    Store store = new Store { Name = name, Address = storeAddress, Latitude = latitude, Longitude = longitude, OpeningHour = openingHours, ClosingHour = closingHours, OpeningDays = openingDaysStr};
                    db.Stores.Add(store);
                    db.SaveChanges();
                    MessageBox.Show("New store was added successfully",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            } 
            else
            {
                MessageBox.Show("You need to fill all values", 
                                "Fill all values", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        public void deleteStore(int id, GMapControl map, DataGridView storesList)
        {
            using (var db = new BookstoreLibContext())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this store?",
                                "Delete confirmation",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Store storeToDelete = db.Stores.FirstOrDefault(x => x.Id == id);
                    if (storeToDelete != null)
                    {
                        db.Addresses.Remove(storeToDelete.Address);
                        db.Stores.Remove(storeToDelete);
                        db.SaveChanges();
                        MessageBox.Show("Store was deleted successfully",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Initializer initializer = new Initializer();
                        initializer.initStoreMarkersOnMap(map);
                        initializer.initStoresList(storesList);
                    }
                }
                
            }
        }
    }
}
