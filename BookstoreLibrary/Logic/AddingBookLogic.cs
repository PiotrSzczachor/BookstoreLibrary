using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;

namespace BookstoreLibrary.Logic
{
    public class AddingBookLogic
    {
        public void changeFlagPicture(string currency, PictureBox flag)
        {
            string startupPath = Environment.CurrentDirectory;
            startupPath = startupPath.Replace(@"\bin\Debug", "");
            string path = Path.Combine(startupPath, @"Images\Icons\Flags\");
            if (currency == "PLN")
            {
                path += "pl.png";
            }
            if (currency == "EUR")
            {
                path += "europeanunion.png";
            }
            if (currency == "USD")
            {
                path += "us.png";
            }
            if (currency == "CHF")
            {
                path += "ch.png";
            }
            if (currency == "GBP")
            {
                path += "gb.png";
            } 
            if (currency == "UAH")
            {
                path += "ua.png";
            }
            try
            {
                flag.Image = Image.FromFile(path);
                flag.SizeMode = PictureBoxSizeMode.StretchImage;
            } catch (FileNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void addBookToDb(string title, string author, string type, string publisher, string pubishYear, string PageNumber)
        {
            using (var db = new BookstoreLibContext())
            {
                bool emptyValue = false;
                string[] values = { title, author, type, publisher, pubishYear, PageNumber };
                foreach (string value in values)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        emptyValue = true;
                    }
                }
                if (emptyValue)
                {
                    MessageBox.Show("All text boxes must be completed",
                                        "Complete all text boxes",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                } else
                {
                    int year = Int32.Parse(pubishYear);
                    int pages = Int32.Parse(PageNumber);
                    Book book = new Book {
                        Title = title,
                        Author = author, 
                        Type = type,
                        Publisher = publisher,
                        PublishYear = year,
                        PageNumber = pages 
                    };
                    db.Books.Add(book);
                    Console.WriteLine(book.Id.ToString());
                }
            }
        }
    }
}
