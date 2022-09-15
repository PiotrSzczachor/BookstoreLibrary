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

        public void deleteUser(int userId, User currentlyLoggedUser)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                using (var db = new BookstoreLibContext())
                {
                    User userToDelete = db.Users.FirstOrDefault(a => a.Id == userId);
                    if (userToDelete != null)
                    {
                        if (userToDelete.Username != currentlyLoggedUser.Username)
                        {
                            Address addressToDelete = userToDelete.Address;
                            if (addressToDelete != null)
                            {
                                db.Addresses.Remove(addressToDelete);
                                db.Users.Remove(userToDelete);
                                db.SaveChanges();
                            }
                        } else
                        {
                            MessageBox.Show("You cannot delete your account",
                                                  "Information",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Information);
                        }
                        
                    }
                }
            }
        }

        public void editUser(int userId, User currentlyLoggedUser, TextBox nameBox, TextBox surnameBox, TextBox usernameBox, TextBox emailBox, ComboBox phoneCode, TextBox phoneBox)
        {
            using (var db = new BookstoreLibContext())
            {
                User userToEdit = db.Users.FirstOrDefault(u => u.Id == userId);
                if (userToEdit != null)
                {
                    if (userToEdit.Id != currentlyLoggedUser.Id)
                    {
                        string wholePhoneNumber = phoneCode.Text + phoneBox.Text;
                        userToEdit.Name = nameBox.Text;
                        userToEdit.Surname = surnameBox.Text;
                        userToEdit.Username = usernameBox.Text;
                        userToEdit.Email = emailBox.Text;
                        userToEdit.PhoneNumber = wholePhoneNumber;
                        db.SaveChanges();
                        MessageBox.Show("User edited successfully",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("You can't edit your account here. If you want to, go to Account in menu.",
                                        "Information",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
