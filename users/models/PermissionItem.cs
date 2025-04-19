using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users.models
{
     public class PermissionItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Permission")]
        public int PermissionId { get; set; } 

        [ForeignKey("Product")]
        public int ProductId { get; set; } 

        [Range(0.01, double.MaxValue, ErrorMessage = "Quantity must be positive")]
        public decimal Quantity { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public DateTime ProductionDate { get; set; } 
        public DateTime ExpiryDate { get; set; }
        public virtual Permission Permission { get; set; } 
        public virtual Product Product { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
