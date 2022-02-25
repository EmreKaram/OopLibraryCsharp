using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Seald
{


    //1)sTRUCT YAPILARDA  BOŞ YAPICI METOT TANIMLAYAMAZSINIZ.
    //2)eĞER YAPICI METOT TANIMLANACAK İSE MUTLAKA PARAMETRE ALMAK ZORUNDADIR. 
    ///3)pARAMTRELİ TANIMLANACAK İSE ,MUTLAKA PARAMETRE DEĞERİ BAŞLANGIÇ DĞERİ ALMAK ZORUNDA 
    ///4)sTRUCT YAPILARINDA  BOŞ YAPICI METOT TANIMLANMADIĞINDA DOLAYI NEW ANAHTAR KELİMESİ KULLANILMAZ İDYE BİR DURUM YOKTUR.. CLASS YAPILARINDA YAPI DERLELENDİĞİNDE EĞER SİEZE DEFAULT BOŞ BİR YAPICI METOT  OLUŞTURMADIYSANIZ ,YAPI DERLENDİĞİNDE OTOMATİK OLARAK " VOİD CTOR()" METODU ÇALIŞITIRILACAKTIR. 
    /////Sturct  içerisindeki primitive tipler için varsayılan ilk değer atamaları gerçekleştirilmektedir. Buna göre sayılsal değerler  için 0 veya 0.0 bool için  false  referans türler için ise null değerlerin atanması söz konusudr. 

   public struct Kitap
    {

        public int Id { get; set; }
        public string Adi { get; set; }
        public string Turu { get; set; }
        public string ISBNNO { get; set; }
        public string YazarAdi { get; set; }


        public Kitap(int Id, string ad, string turu, string ISBNnO, string YazarAdi)
        {

            this.Id = Id;
            this.Adi = ad;
            this.Turu = turu;
            this.ISBNNO = ISBNnO;
            this.YazarAdi = YazarAdi;


        }
    }
}
