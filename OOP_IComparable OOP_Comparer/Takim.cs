using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IComparable_OOP_Comparer
{
    public class Takim :IComparable<Takim>
    {
        public string Adi { get; set; }
        public byte Puan { get; set;  }
        public sbyte Averaji { get; set; }

        //public int CompareTo(Takim other)
        //{
        //    if (this.Puan<other.Puan)
        //    {
        //        return 1; 
        //    }
        //    else if (this.Puan> other.Puan)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        public override string ToString()
        {
            return this.Adi;
        }

        public int CompareTo(Takim other)
        {
            if (this.Puan < other.Puan) return 1;
            else if (this.Puan > other.Puan) return -1;
            else return 0;
           
        }


      
    }
    //Classlarımızın  farklı  çzelliklerine göre sıralamak istersek ,
    class PuaniKucuktenBuyugeSiralama : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            return  -(x.CompareTo(y));
        }
    }

    class AverejaGoreBuyuktenKucugeSiralama : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            if (x.Averaji<y.Averaji)
            {
                return 1;
            }
            else if (x.Averaji>y.Averaji)
            {
                return -1; 
            }
            else
            {
                return 0;
            }
        }
    }

    class AverajaGoreKucuktenBuyugeSirala:IComparer<Takim>
    {

        public int Compare(Takim x, Takim y)
        {
            AverejaGoreBuyuktenKucugeSiralama avg = new AverejaGoreBuyuktenKucugeSiralama();
          return  -( avg.Compare(x, y));
  
        }
    }

    class AdaGoreBuyuktenKucugeSiralama :IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            return x.Adi.CompareTo(y.Adi);
        }



    }
    class AdagoreKucuktenBuyugeDogruSiralama :IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            AdaGoreBuyuktenKucugeSiralama ads = new AdaGoreBuyuktenKucugeSiralama();
            return -(ads.Compare(x, y));
        }
    }






}
