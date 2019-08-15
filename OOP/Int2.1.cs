using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class SmartPhone : MobilePhone
    {
        public bool hasFontCam { get; set; }
        public SmartPhone()
        {
            hasCamera = true;
            _phoneType = "Smart Phone";
        }
    }
}
