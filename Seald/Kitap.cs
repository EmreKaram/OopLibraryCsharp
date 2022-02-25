using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seald
{  
    
     //Seald kelimesi ile ,kendisinden nesne türetebilir .Fakat miras verilemez anlamına gelir.. Absstract classlar kendilerinden nesne üretmelerine izin veridlikleri gibi aynı zamanda örneklenedebilirler.. 
    public class BaseKitap
    {


        public DateTime OluşturulmaTarihi  { get; set; }
        public DateTime DuzenlenmeTarihi  { get; set; }


        public virtual void LogTut()
        {
            //Log tutuma kodları 
        }


        public virtual void KullanıcıGetir()
        {
            // get usert
        }


    }


   public  class Kitap:BaseKitap
    {

        public int Id { get; set; }
        public string Adi { get; set; }
        public string Turu { get; set; }
        public string ISBNNO { get; set; }
        public string YazarAdi { get; set; }


        public override void LogTut()
        {
         
        }
        public sealed override void KullanıcıGetir()  //Fark Burda 
        {
           
        }



    }


    class KitapOlustur:Kitap
    {
        public override void LogTut()
        {
            base.LogTut();
        }

        //KullanıcıGetir() METODU SEALD OLARAK işaretlendğinden ,ilgili metoda ulaşamıycalsınız..
    }
}
