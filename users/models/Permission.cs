using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users.models
{
   public class Permission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PermissionNumber { get; set; } 

        [Required]
        public DateTime PermissionDate { get; set; } 

        [ForeignKey("Warehouse")]
        public int WarehouseId { get; set; } 
        public virtual Warehouse Warehouse { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<PermissionItem> Items { get; set; } = new List<PermissionItem>();
    }
}

