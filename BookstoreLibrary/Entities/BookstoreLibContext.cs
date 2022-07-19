using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreLibrary.Entities
{
    public class BookstoreLibContext : DbContext
    {
        public BookstoreLibContext() : base()
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookToBorrow> BooksToBorrow { get; set; }
        public DbSet<BookToSell> BooksToSell { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SoldBook> SoldBooks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
