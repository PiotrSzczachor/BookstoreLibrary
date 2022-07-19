using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookstoreLibrary.Entities
{
    public class BookToSell
    {
        [Key]
        public int Id { get; set; }
        public virtual Book Book { get; set; }
        public float Price { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }
    }
}
