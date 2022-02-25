using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFABilgeBurger
{
       public class Siparis
    {
        public Menu SecilenMenu { get; set; }

        public Boyut Boyutu { get; set; }
        public List<Extra> ExtraMalzemesi { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar  { get; set; }


        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SecilenMenu.Fiyati;

            switch (Boyutu)
            {
             
                case Boyut.Orta: ToplamTutar += ToplamTutar * 0.10m; break;
                  
                case Boyut.Buyuk:ToplamTutar += ToplamTutar * 0.20m; break;           
           
            }

            foreach (Extra exMalzeme in ExtraMalzemesi)
            {
               ToplamTutar +=  exMalzeme.Fiyati;

                ToplamTutar = ToplamTutar * Adet;


            }
        }





    }
}
