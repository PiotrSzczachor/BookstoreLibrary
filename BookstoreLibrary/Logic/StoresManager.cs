using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;

namespace BookstoreLibrary.Logic
{
    public class StoresManager
    {
        public void addStore(string name, string openingHour, string openingMinute, string closingHour, string closingMinute,
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
                    Address storeAddress = new Address { Street = street, City = city, PostalCode = postalCode, Number = number };
                    db.Addresses.Add(storeAddress);
                    db.SaveChanges();

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
    }
}
