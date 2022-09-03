using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;

namespace BookstoreLibrary.Logic
{
    public class UsersManager
    {
        public bool editAdress(User user, string street, string number, string city, string postalCode)
        {
            using (var db = new BookstoreLibContext())
            {
                Address addressToEdit = db.Addresses.FirstOrDefault(a => a.Id == user.Address.Id);
                if (addressToEdit != null)
                {
                    addressToEdit.Street = street;
                    addressToEdit.Number = number;
                    addressToEdit.City = city;
                    addressToEdit.PostalCode = postalCode;
                    db.SaveChanges();
                    MessageBox.Show("Address edited successfully",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return true;
                } else
                {
                    return false;
                }
            }
        }
    }
}
