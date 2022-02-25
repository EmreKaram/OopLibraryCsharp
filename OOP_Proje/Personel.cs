using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Proje
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyadi { get; set; }
        public string TCKN { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public DateTime IseGirisTarhi { get; set; }
        public Unvan Unvan { get; set; }
        public string PersonelResmi { get; set; }
        public object Tag { get; set; }

    }
}
