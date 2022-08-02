using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreLibrary.Logic
{
    public class PasswordValidator
    {
        public bool checkPasswordLength(string password, PictureBox icon)
        {
            if (password.Length >= 8)
            {
                icon.Image = Image.FromFile(@"C:\Users\piotr\source\repos\BookstoreLibrary\BookstoreLibrary\Images\Icons\accept.png");
            } else
            {
                icon.Image = Image.FromFile(@"C:\Users\piotr\source\repos\BookstoreLibrary\BookstoreLibrary\Images\Icons\cancel.png");
            }
            return password.Length>8;
        }

        public bool checkIfPasswordContainsSpecialChar(string password, PictureBox icon)
        {
            var specialCharRegex = new Regex("[^A-Za-z0-9]");
            if (specialCharRegex.IsMatch(password))
            {
                icon.Image = Image.FromFile(@"C:\Users\piotr\source\repos\BookstoreLibrary\BookstoreLibrary\Images\Icons\accept.png");
            } else
            {
                icon.Image = Image.FromFile(@"C:\Users\piotr\source\repos\BookstoreLibrary\BookstoreLibrary\Images\Icons\cancel.png");
            }
            return !password.Any(ch => !Char.IsLetterOrDigit(ch));
        }

        public bool checkIfPasswordContainsCapitalLetter(string password, PictureBox icon)
        {
            if (password.Any(char.IsUpper))
            {
                icon.Image = Image.FromFile(@"C:\Users\piotr\source\repos\BookstoreLibrary\BookstoreLibrary\Images\Icons\accept.png");
            } else
            {
                icon.Image = Image.FromFile(@"C:\Users\piotr\source\repos\BookstoreLibrary\BookstoreLibrary\Images\Icons\cancel.png");
            }
            return password.Any(char.IsUpper);
        }

        public bool checkIfPasswordsMatch(string password, string rePassword, PictureBox icon)
        {
            if (password == rePassword)
            {
                icon.Image = Image.FromFile(@"C:\Users\piotr\source\repos\BookstoreLibrary\BookstoreLibrary\Images\Icons\accept.png");
            } else
            {
                icon.Image = Image.FromFile(@"C:\Users\piotr\source\repos\BookstoreLibrary\BookstoreLibrary\Images\Icons\cancel.png");
            }
            return password == rePassword;
        }

        public bool validatePassword(string password, string rePassword, PictureBox LenIcon, PictureBox SpecialIcon, PictureBox CapitalIcon, PictureBox MatchIcon)
        {
            bool minLen = checkPasswordLength(password, LenIcon);
            bool specialChar = checkIfPasswordContainsSpecialChar(password, SpecialIcon);
            bool containsCapitalLetter = checkIfPasswordContainsCapitalLetter(password, CapitalIcon);
            bool passwordsMatch = checkIfPasswordsMatch(password, rePassword, MatchIcon);
            return minLen && specialChar && containsCapitalLetter && passwordsMatch;
        }
    }
}
