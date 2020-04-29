using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carPartsShop.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
#nullable disable
        public ICollection<Product> Products { get; set; }

    }
}
