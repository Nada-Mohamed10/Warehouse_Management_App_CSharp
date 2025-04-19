using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users.models
{
    // supplier
   public  class SupplyOrder
    {
        [Key]

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string PermissionNumber { get; set; }
        [Required]
        public DateTime PermissionDate { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }

        [ForeignKey("Warehouse")]
        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<SupplyOrderItem> Items { get; set; } = new List<SupplyOrderItem>();

    }
}
