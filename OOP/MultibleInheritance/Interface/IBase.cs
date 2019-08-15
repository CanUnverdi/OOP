using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.MultibleInheritance.Interface
{
    public interface IBase
    {
        int ID { get; set; }
        DateTime AddDate { get; set; }
        DateTime UpdateDate { get; set; }
        DateTime DeleteDate { get; set; }

        Status Status { get; set; }
    }
}
