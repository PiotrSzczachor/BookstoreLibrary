using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookstoreLibrary.Entities
{
    public class SoldBook
    {
        [Key]
        public int Id { get; set; }
        public virtual BookToSell Book { get; set; }
        public virtual User Buyer { get; set; }
        public DateTime SoldDate { get; set; }
        public bool isShipped { get; set; }
    }
}
