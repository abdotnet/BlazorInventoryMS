using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Range(1, int.MaxValue,ErrorMessage = "Quantity must be greate than or equal 1")]
        public int Quantity { get; set; }
        [Range(50, int.MaxValue, ErrorMessage = "Price must be greate than or equal 50")]
        public decimal Price { get; set; }
    }
}
