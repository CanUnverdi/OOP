using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Encapsulation
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private string _description;
        public string Description { get { return _description; } set { _description = value; } }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Fiyat Negatif Olamaz!");
                }
            }
        }

        private decimal _unitInStock;
        public decimal UnitInStock { get { return _unitInStock; } set { value = _unitInStock; } }
    }
}
