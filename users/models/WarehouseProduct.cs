using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users.models
{
   public  class WarehouseProduct
    {

        [Key, Column(Order = 0)]
        public int IdWarehouse { get; set; }
        public Warehouse Warehouse { get; set; }
        [Key, Column(Order = 1)]
        public int IdProduct { get; set; }
        public virtual Product Products { get; set; }
       
        

        public int Quantity { get; set; }
        public  DateTime TransactionDate { get; set; }

        
    }
}
