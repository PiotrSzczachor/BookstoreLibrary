﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;

namespace BookstoreLibrary.Logic
{
    public class BooksManager
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

        private int addBookToDb(string title, string author, string type, string publisher, string pubishYear, string PageNumber)
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
                    return -1;
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
                    db.SaveChanges();
                    Console.WriteLine(book.Id.ToString());
                    return book.Id;
                }
            }
        }

        public void addBookForSale(string title, string author, string type, string publisher, string pubishYear, string PageNumber, string quantity, string price, string currency)
        {
            int bookId = addBookToDb(title, author, type, publisher, pubishYear, PageNumber);
            if (bookId != -1)
            {
                string[] values = { quantity, price, currency };
                bool emptyValue = false;
                foreach (string value in values)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        emptyValue = true;
                    }
                }
                if (!emptyValue)
                {
                    using (var db = new BookstoreLibContext())
                    {
                        BookToSell book = new BookToSell();
                        int quantityInt = Int32.Parse(quantity);
                        price = price.Replace(',', '.');
                        float pricefloat;
                        float.TryParse(price, NumberStyles.Any, CultureInfo.InvariantCulture, out pricefloat);
                        book.Quantity = quantityInt;
                        book.Price = pricefloat;
                        book.Currency = currency;
                        Book coreBook = db.Books.FirstOrDefault(b => b.Id == bookId);
                        book.Book = coreBook;
                        db.BooksToSell.Add(book);
                        db.SaveChanges();
                        MessageBox.Show("Book added successfully",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("All text boxes must be completed",
                                    "Complete all text boxes",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            } 
            else
            {
                MessageBox.Show("Failed to add book to database",
                                "Fail",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void addBookToBorrow(string title, string author, string type, string publisher, string pubishYear, string PageNumber, string quantity)
        {
            int bookId = addBookToDb(title, author, type, publisher, pubishYear, PageNumber);
            if (bookId != -1)
            {
                if (!string.IsNullOrEmpty(quantity))
                {
                    using (var db = new BookstoreLibContext())
                    {
                        int quantityInt = Int32.Parse(quantity);
                        BookToBorrow bookToBorrow = new BookToBorrow();
                        bookToBorrow.Quantity = quantityInt;
                        bookToBorrow.Book = db.Books.FirstOrDefault(b => b.Id == bookId);
                        db.BooksToBorrow.Add(bookToBorrow);
                        db.SaveChanges();
                        MessageBox.Show("Book added successfully",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            } else
            {
                MessageBox.Show("Failed to add book to database",
                                "Fail",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        public void deleteBook(int id)
        {
            using(var db = new BookstoreLibContext())
            {
                deleteBookToSell(id);
                deleteBookToBorrow(id);
                Book book = db.Books.FirstOrDefault(b => b.Id == id);
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }
        public void deleteBookToSell(int bookId)
        {
            using (var db = new BookstoreLibContext())
            {
                BookToSell bookToSell = db.BooksToSell.FirstOrDefault(b => b.Book.Id == bookId);
                if (bookToSell != null)
                {
                    db.BooksToSell.Remove(bookToSell);
                    db.SaveChanges();
                }
            }
        }
        public void deleteBookToBorrow(int bookId)
        {
            using (var db = new BookstoreLibContext())
            {
                BookToBorrow bookToBorrow = db.BooksToBorrow.FirstOrDefault(b => b.Book.Id == bookId);
                if (bookToBorrow != null)
                {
                    db.BooksToBorrow.Remove(bookToBorrow);
                    db.SaveChanges();
                }
            }
        }
    }
}
