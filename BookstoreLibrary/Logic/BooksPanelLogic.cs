using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;

namespace BookstoreLibrary.Logic
{
    public class BooksPanelLogic
    {
        public void fillTableWithBooksToBorrow(DataGridView booksTable, Label label)
        {
            using (var db = new BookstoreLibContext())
            {
                var booksToBorrow = db.BooksToBorrow.Select(b => new { Id = b.Id, Title = b.Book.Title, Quantity = b.Quantity}).ToList();
                booksTable.DataSource = booksToBorrow;
                label.Text = "Books to borrow:";
            }
        }

        public void fillTableWithBooksToSell(DataGridView booksTable, Label label)
        {
            using (var db = new BookstoreLibContext())
            {
                var booksToBorrow = db.BooksToSell.Select(b => new { Id = b.Id, Title = b.Book.Title, Price = b.Price, Currency = b.Currency, Quantity = b.Quantity}).ToList();
                booksTable.DataSource = booksToBorrow;
                label.Text = "Books to sell:";
            }
        }
    }
}
