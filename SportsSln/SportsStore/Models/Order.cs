using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage ="Please Enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter the first address line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please Enter a City")]
        public string City { get; set; }

        [Required(ErrorMessage ="Please Enter a State")]
        public string State { get; set; }

        public string Zip { get; set; }
        
        [Required(ErrorMessage = "Please Enter a Country")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }

        [BindNever]
        public bool Shipped { get; set; }
    }
}
