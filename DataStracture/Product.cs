using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStracture
{
   public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150), Required]
        public string Name { get; set; }


        public int SeleCount { get; set; }


        public bool isActive { get; set; }

        public decimal Price { get; set; }
        [MaxLength(10), Required]
        public string SaveDate { get; set; }

        [MaxLength(5), Required]
        public string SaveTime { get; set; }

        public string Descriptior { get; set; }

    }
}
