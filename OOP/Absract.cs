using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Absract
    {

        public string Marka { get; set; }
        public string Aciklama { get; set; }

       
        public abstract string Cal();
    }
}
