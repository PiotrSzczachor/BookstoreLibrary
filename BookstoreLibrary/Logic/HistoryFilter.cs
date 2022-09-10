using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;

namespace BookstoreLibrary.Logic
{
    internal class HistoryFilter
    {
        public class HistoryObject { 
            int Id;
            string bookTitle;
            int bookId;
            string action;
            DateTime actionDate;
            public HistoryObject(int id, string title, int bookid, string action_, DateTime date) {
                Id = id;
                bookTitle = title;
                bookId = bookid;
                action = action_;
                actionDate = date;
            }
        };
        public void filterBy(string action, DataGridView historyTable, string username, Label label)
        {
            using (var db = new BookstoreLibContext())
            {
                User user = db.Users.FirstOrDefault(u => u.Username == username);
                if (user != null)
                {
                    var history = user.History.Select(h => new { Id = h.Id, Book = h.Book.Title, BookId = h.Book.Id, Action = h.Action, ActionDate = h.ActionDate }).Where(h => h.Action == action).ToList();
                    label.Text = username + " " + action + " history:";
                }
            }
        }
    }
}
