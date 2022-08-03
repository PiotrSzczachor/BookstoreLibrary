using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;

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

        private void addNewUser(string name, string surname, string email, string phone, string username, string password, Address address)
        {
            using (var db = new BookstoreLibContext())
            {
                DateTime joinDate = DateTime.Now;
                User newUser = new User { Name = name, Surname = surname, Username = username, Email = email, PhoneNumber = phone};
            }
        }


        public void signUp(string name, string surname, string email, string phone, string username, string password, string repeatedPassword, bool isPasswordValid)
        {
            List<string> textBoxes = new List<string> { name, surname, email, phone, username, password, repeatedPassword };
            if (CheckIfAllTextBoxesAreFilled(textBoxes))
            {
                if (checkIfEmailIsValid(email))
                {
                    if (isPasswordValid)
                    {
                        //addNewUser(name, surname, email, phone, username, password);
                    }
                    else
                    {
                        MessageBox.Show("Bad password",
                               "Password does not meet the requirements",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("Incorect email format",
                               "Your email format is incorect.",
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
