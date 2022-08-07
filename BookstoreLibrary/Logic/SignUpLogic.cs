using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;
using EmailSender;

namespace BookstoreLibrary.Logic
{
    public class SignUpLogic
    {
        private bool CheckIfAllTextBoxesAreFilled(List<string> textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (String.IsNullOrEmpty(textBox))
                {
                    return false;
                }
            }
            return true;
        }
        private bool checkIfEmailIsValid(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }

        private void addNewUser(string name, string surname, string email, string phone, string username, string password, string street, string number, string city, string postalCode)
        {
            using (var db = new BookstoreLibContext())
            {
                DateTime joinDate = DateTime.Now;
                Address address = new Address { Street = street, City = city, Number = number, PostalCode = postalCode };
                Role role = db.Roles.FirstOrDefault(r => r.IsUser == true);
                db.Addresses.Add(address);
                Encoder encoder = new Encoder();
                string encodedPassword = encoder.encodePassword(password);
                User newUser = new User { Name = name, Surname = surname, Username = username, Email = email, PhoneNumber = phone, Address = address, AccountBalance = 0, JoinDate = joinDate, Password = encodedPassword , Role = role};
                db.Users.Add(newUser);
                db.SaveChanges();
            }
        }


        public void signUp(string name, string surname, string email, string phone, string username, string password, string repeatedPassword, bool isPasswordValid, string street, string number, string city, string postalCode)
        {
            List<string> textBoxes = new List<string> { name, surname, email, phone, username, password, repeatedPassword, street, number, city, postalCode};
            if (CheckIfAllTextBoxesAreFilled(textBoxes))
            {
                if (checkIfEmailIsValid(email))
                {
                    if (isPasswordValid)
                    {
                        addNewUser(name, surname, email, phone, username, password, street, number, city, postalCode);
                        Email emailSender = new Email();
                        string body = "Hello " + name + "!\nYour account in out Bookstore&Library is now active. You can now login using your username: " + username;
                        emailSender.sendEmail(email, body, "Bookstore&Library confirmation email");
                        MessageBox.Show("Success",
                                        "Your account was created successfully. We send confirmation at your email.",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Password does not meet the requirements",
                               "Bad password",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("Your email format is incorect.",
                               "Incorect email format",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Fill all text boxes",
                               "You need to fill all text boxes.",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }
    }
}
