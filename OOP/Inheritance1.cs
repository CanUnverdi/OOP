using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
          */
    public class BaseEntity
    {
        public int ID { get; set; }


        private DateTime _addDate = DateTime.Now;
        public DateTime AddDatea 
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        private DateTime _updateDate = DateTime.Now;
        public DateTime UpdateDate
        {
            get { return _updateDate; }
            set { _updateDate = value; }
        }

        private DateTime _deleteDate = DateTime.Now;
        public DateTime DeleteDate { get { return _deleteDate; } set { value = _deleteDate; } }


        private bool _isActive = true;
        public bool IsActive { get { return _isActive; } set { value = _isActive; } }
    }
}
