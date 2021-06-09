using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Required to fill Name to upload")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required to fill Email to upload")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required to fill Phone to upload")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Required to fill Will attend to upload")]
        public bool? WillAttend { get; set; }
    }
}
