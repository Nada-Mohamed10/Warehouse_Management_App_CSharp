using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users.models
{
    class TransferProduct
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("FromWarehouse")]
        public int FromWarehouseId { get; set; }
        public virtual Warehouse FromWarehouse { get; set; }

        [ForeignKey("ToWarehouse")]
        public int ToWarehouseId { get; set; }
        public virtual Warehouse ToWarehouse { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime TransferDate { get; set; } = DateTime.Now;


    }
}
