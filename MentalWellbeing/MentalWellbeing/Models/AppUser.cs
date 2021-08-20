using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentalWellbeing.Models
{
    public enum Role
    {
        Admin,
        Standard
    }
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Discussion> Discussions { get; set; }
        public Role SelectedRole { get; set; }
    }
}
