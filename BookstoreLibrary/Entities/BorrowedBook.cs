using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookstoreLibrary.Entities
{
    public class BorrowedBook
    {
        [Key]
        public int Id { get; set; }
        public virtual BookToBorrow Book { get; set; }
        public virtual User BorrowedBy { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime DeadlineDate { get; set; }
    }
}
