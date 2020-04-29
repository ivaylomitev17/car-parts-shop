using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carPartsShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        

    }
}
