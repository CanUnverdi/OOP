using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class MobilePhone : BasePhone
    {
        public bool hasCamera { get; set; }
        public bool hasTouchScreen { get; set; }

        public MobilePhone()
        {
            _phoneType = "Mobile Phone";
        }

        public MobilePhone(bool hasCamera, bool hasTouchScreen, string connectionType, string brand)
        {
            this.hasCamera = hasCamera;
            this.hasTouchScreen = hasTouchScreen;
            _connectionType = connectionType;
            _phoneType = "Mobile Phone";
        }

        public string TakePhoto()
        {
            if (hasCamera)
            {
                return "Fotograf çekebilirsiniz";
            }
            else
            {
                return "Kameran yok ki?";
            }
        }


        public override string Cal()
        {
            return "Mobil telefon sesi";
        }
    }
}
