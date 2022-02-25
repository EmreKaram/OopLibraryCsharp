using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable__IEnumerator_Kullanimlari
{
    public enum Mevkiiler
    {
        Kaleci ,Defans , OrtaSaha,Forvet
    }



  public  class Futbolcu
    {
        public string AdiSoyadi { get; set; }
        public byte FormaNumarasi { get; set; }
        public Mevkiiler Mevkisi { get; set; }

        public override string ToString()
        {
            return string.Format("{0}({1})-{2}", this.AdiSoyadi, this.FormaNumarasi, this.Mevkisi);
        }



    }

}
