using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidlyy.Models
{
    public class MembershipType
    {
        public byte id { get; set; }
        public String Name { get; set; }
        public short signUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}