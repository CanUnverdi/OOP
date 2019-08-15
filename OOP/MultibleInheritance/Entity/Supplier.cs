using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.MultibleInheritance.Entity
{
    public class Supplier : BaseEntity, IAddressInfo, ICompanyInfo
    {
        public string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Region { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CampanyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public string ContactName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
}
