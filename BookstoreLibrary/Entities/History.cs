using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookstoreLibrary.Entities
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        public string Action { get; set; }
        public virtual Book Book { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
