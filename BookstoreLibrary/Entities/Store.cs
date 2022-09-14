using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookstoreLibrary.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Address Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string OpeningHour { get; set; }
        public string ClosingHour { get; set; }
        public string OpeningDays { get; set; }
    }
}
