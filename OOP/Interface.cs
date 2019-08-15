using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
   
    {
        public interface ITasit
        {
            
            string Marka { get; set; }
            string Model { get; set; }

           
            int MotorGucu();

            string YakitTuketimi();
            byte KapiSayisi();
        }
    }
}
