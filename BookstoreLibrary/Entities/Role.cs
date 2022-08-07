using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookstoreLibrary.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Boolean IsAdmin { get; set; }
        public Boolean IsUser { get; set; }
        public Boolean IsSeller { get; set; }
    }
}
