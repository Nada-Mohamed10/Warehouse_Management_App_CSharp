using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users.models
{
   public  class Product
    {
        [Key]
        public int IdProduct { get; set; }
        [Required]
        public string CodeProduct { get; set; }
        [Required]
       
        public string nameProduct { get; set; }

        public string MeasurementUnit { get; set; }

        public virtual  List<WarehouseProduct> WarehouseProducts { get; set; }
    }

}
