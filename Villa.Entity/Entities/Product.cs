using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Entity.Entities
{
    public class Product:BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public int bedroomCount { get; set; }
        public int bathroomCount { get; set; }
        public int Area { get;set; }
        public int Floor { get;set; }
        public int ParkingCount { get; set; }
    }
}
