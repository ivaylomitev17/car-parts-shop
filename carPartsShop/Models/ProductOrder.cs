using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carPartsShop.Models
{
    public class ProductOrder
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }


    }
}