using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidlyy.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        [Required(AllowEmptyStrings = true)]
        public String BirthDate { get; set; }
    }
}