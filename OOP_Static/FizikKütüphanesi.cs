using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static
{
   public static class FizikKütüphanesi


        //Eğer nesneye bağımlı işlemler gerçekleştirmiyor iseniz .-Yani amacınız sadece belirli bir duruma hizmet eden birden fazla ogeyi bir araya toplamak ise ilgili sınıfı static olarak işarteleyebiliriz. ve içerisindeki tüm ögelere instancedan bağımsız olarak erişebilirisiniz. 

        //Static sınıflar içerisinde yanzlıca static ögeler barındırılır. 

        //Static bir class başka bir classdan Kalitim alamaz .Ancak .net freamework mantığı gereği ,tum sınıflar system.Object  sınıfından kalıtım  alırlar. Static sınıflarda bu kalitim işlemine dahildir..

        //static sınıfların en güzel örnek math ve file sınıfıdır. 
        //AMAC => Aynı amaca hizmet eden işlemler bir arada toplanmaıştır.Math 

        //Ancak her sınıfı statik bir sınıf olarak işaretlenmemlidir. Çünkü tanımlanan her static sınıf size performans kaybı yaşatacaktır. . 




    {
        public static decimal YerCekimiKuvetti  { get { return 9.80M; } }
        public  const int kaldirmaKuvvet = 20;
        //Const => sabit değer ya arkada zaten static olma özelliğine sahip , dolayısı ile static olarak işartlenemez .

        //Sadece okunabilir değişkenler oluşturmak için kullanılan anahtar kelime .
        public static readonly int TestKuvveti = 5;
      
  

        public static void Kaldirma()
        {

        }



    }
}
