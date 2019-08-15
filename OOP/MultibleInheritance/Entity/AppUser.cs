using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.MultibleInheritance.Entity
{
   
    {
        public class AppUser : BaseEntity, IAddressInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }

            public Gender Gender { get; set; }
            public Role Role { get; set; }

            //IAddressInfo interface'sinden geldi
            public string Address { get; set; }
            public string Region { get; set; }
        }
}
