using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group4.KANAP.Data.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BloodType { get; set; }
        public DateTime? Birthday { get; set; }
        public string Hospital { get; set; }
        public string Gender { get; set; }
        public int MemberType { get; set; }
    }
}
