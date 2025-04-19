using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users.models
{
   public  class Customer
    {
        [Key]
        public int  IdCustomer {  get; set; }
        [Required]
        public string NameCustomer { get; set; }
        [Required]
        public string PhoneCustomer { get; set; }
        [Required]
        public string FaxCustomer { get; set; }

        public string MobileCustomer { get; set; }
        [Required]
        public string EmailCustomer { get; set; }

        public string WebsiteCustomer { get; set; }

    }
}
