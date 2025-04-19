using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users.models
{
 public   class Warehouse
    {
        [Key]
        public int IdWarehouse { get; set; }
        [Required]
        public string NameWarehouse { get; set; }
        [Required]
        public string AddressWarehouse { get; set; }
        [Required]
        public string MangerWarehouse { get; set; }

        public virtual List<WarehouseProduct> WarehouseProducts { get; set; }
    }
}
