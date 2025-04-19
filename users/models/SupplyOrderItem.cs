using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users.models
{
    public  class SupplyOrderItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("SupplyOrder")]
        public int SupplyOrderId { get; set; }

        [ForeignKey("Product")]
        public int IdProduct { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Quantity must be positive")]
        public decimal Quantity { get; set; }

        public virtual SupplyOrder SupplyOrder { get; set; }
        public virtual Product Product { get; set; }

    }
}
