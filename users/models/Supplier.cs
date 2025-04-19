using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users.models
{
   public class Supplier
    {
        [Key]
        public int IdSupplier { get; set; }
        [Required]
        public string NameSupplier { get; set; }
        [Required]
        public string PhoneSupplier { get; set; }
        [Required]
        public string FaxSupplier { get; set; }

        public string MobileSupplier { get; set; }
        [Required]
        public string EmailSupplier { get; set; }

        public string WebsiteSupplierr { get; set; }
       
    }
}
