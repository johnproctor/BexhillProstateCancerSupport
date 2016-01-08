using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BPCS.Models
{
    public class ContactModel
    {
        [Required]
        public String Name { get; set; }

        [Required]
        public String EmailAddress { get; set; }

        [Required]
        public String Message { get; set; }
    }
}