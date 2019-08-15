using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class BasePhone
    {
        protected string _brand;
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        protected string _phoneType;
        public string PhoneType
        {
            get { return _phoneType; }
        }

        protected string _connectionType;
        public string ConnectionType { get { return _connectionType; } set { _connectionType = value; } }

        public virtual string Cal()
        {
            return "Ahizeli telefon sesi";
        }

        
        public BasePhone()
        {
         
            _phoneType = "Ahizeli Telefon";
        }

        public BasePhone(string brand, string connectionType)
        {
            _brand = brand;
            _connectionType = connectionType;
            _phoneType = "Ahizeli Telefon";
        }
    }
}
