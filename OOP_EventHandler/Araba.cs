using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EventHandler
{
    public class Araba
    {
// Event (olaylar):Kullanıcının fare ile tıklaması ,Klavyeden hernagi bir tuşa basmam gibi işletim sistemi üzerinden gerçkelştirebilidğiniz eylmelere event denir ..Bir birleşen üzerinde meydana gelen olayları takip edeb ve bunları yakalayan mekanizmadır. 

        public delegate void HizAsimiFonks();
        public Araba(int hiz ,string marka)
        {
            this.Hiz = hiz;
            this.Marka = marka;
        }

        //Event içerisinde isteniler eriş bildirgeci kullanılabilir. 
        public event HizAsimiFonks HizAşimi;
        private int _hiz;
        public int Hiz
        {
        get { return _hiz; }
            set 
            {
                _hiz = value;
                if (value>120)
                {
                    HizAşimi(); 
                }
            }
        }

        private string _marka;
        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }



    }
}
