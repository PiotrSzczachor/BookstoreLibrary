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
        string apiKey = "AiePEZC3a_AhN_9YAvmhZ55zw296iW_-ZEWUwf-cHyPpecM6AnOL6bLCDz9qQwnP";
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
                    IGeocoder geocoder = new BingMapsGeocoder(apiKey);
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
                    if (openingDaysStr.Length > 0) { openingDaysStr = openingDaysStr.Remove(openingDaysStr.Length - 1, 1); }
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
                    }
                }
                
            }
        }

        public void getStoreInfo(int storeId, TextBox nameBox, ComboBox openingHourBox, ComboBox openingMinuteBox,
                                 ComboBox closingHourBox, ComboBox closingMinuteBox, CheckedListBox daysList,
                                 TextBox streetBox, TextBox numberBox, TextBox cityBox, TextBox postalCodeBox)
        {
            using (var db = new BookstoreLibContext())
            {
                Store store = db.Stores.FirstOrDefault(x => x.Id == storeId);
                string openingHour = store.OpeningHour.Split(':').First();
                string closingHour = store.ClosingHour.Split(':').First();
                string openingMinute = store.OpeningHour.Split(':').Last();
                string closingMinute = store.ClosingHour.Split(':').Last();
                nameBox.Text = store.Name;
                openingHourBox.Text = openingHour;
                openingMinuteBox.Text = openingMinute;
                closingHourBox.Text = closingHour;
                closingMinuteBox.Text = closingMinute;
                string[] weekDays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
                string[] openingDays = store.OpeningDays.Split(',');
                foreach (string day in weekDays)
                {
                    daysList.Items.Add(day);
                }
                for (int i = 0; i < daysList.Items.Count; i++)
                {
                    if (openingDays.Contains((string)daysList.Items[i]))
                    {
                        daysList.SetItemChecked(i, true);
                    }
                }
                streetBox.Text = store.Address.Street;
                numberBox.Text = store.Address.Number;
                cityBox.Text = store.Address.City;
                postalCodeBox.Text = store.Address.PostalCode;
                Initializer initializer = new Initializer();
                initializer.initHoursComboBox(openingHourBox);
                initializer.initHoursComboBox(closingHourBox);
                initializer.initMinutesComboBox(openingMinuteBox);
                initializer.initMinutesComboBox(closingMinuteBox);
            }
        }

        public async void editStore(int storeId, string nameBox, string openingHourBox, string openingMinuteBox,
                                 string closingHourBox, string closingMinuteBox, CheckedListBox daysList,
                                 string streetBox, string numberBox, string cityBox, string postalCodeBox)
        {
            string days = "";
            foreach (string day in daysList.CheckedItems)
            {
                days += day + ",";
            }
            days = days.Remove(days.Length - 1, 1);
            string openingHour = openingHourBox + ":" + openingMinuteBox;
            string closingHour = closingHourBox + ":" + closingMinuteBox;
            using (var db = new BookstoreLibContext())
            {
                Store storeToEdit = db.Stores.FirstOrDefault(s => s.Id == storeId);
                if (storeToEdit != null)
                {
                    BookstoreLibrary.Entities.Address address = storeToEdit.Address;
                    address.Street = streetBox;
                    address.Number = numberBox;
                    address.City = cityBox;
                    address.PostalCode = postalCodeBox;
                    storeToEdit.Name = nameBox;
                    storeToEdit.OpeningHour = openingHour;
                    storeToEdit.ClosingHour = closingHour;
                    storeToEdit.OpeningDays = days;
                    var storeAddress = streetBox + " " + numberBox + ", " + cityBox + ", " + postalCodeBox;
                    IGeocoder geocoder = new BingMapsGeocoder(apiKey);
                    IEnumerable<Geocoding.Address> coordinates = await geocoder.GeocodeAsync(storeAddress);
                    double latitude = coordinates.First().Coordinates.Latitude;
                    double longitude = coordinates.First().Coordinates.Longitude;
                    storeToEdit.Latitude = latitude;
                    storeToEdit.Longitude = longitude;
                    db.SaveChanges();
                    MessageBox.Show("Store was edited successfully",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

    }
}
