using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Enum
{
  public enum Departmanlar
    {
        Yazilim,SistemAgUzmanlıgı,GrafikTasarim,Office,Muhasebe,İnsanKaynaklari,ERP
    }

 public   class Personel
    {

        private string _adiSoyadi;

        public string AdiSoyadi
        {
            get { return _adiSoyadi; }
            set { _adiSoyadi = value; }
        }
        private Departmanlar _departman;
        public Departmanlar Departman
        {
            get { return _departman; }
            set { _departman = value; }
        }
    }
}
