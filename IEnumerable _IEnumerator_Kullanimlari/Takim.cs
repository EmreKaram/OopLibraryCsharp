using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable__IEnumerator_Kullanimlari
{
    public class Takim : IEnumerable
    {

        private Futbolcu[] TakimOyunculari { get; set; }

        public int  FutbolcuSayisi { get{ return this.TakimOyunculari.Length; } }

        public double FormaNumaraOrtalamasi
        {
            get
            {
                double ortalama = 0;
               IEnumerator sayac =  TakimOyunculari.GetEnumerator();
                while(sayac.MoveNext())
                {
                    ortalama += ((Futbolcu)sayac.Current).FormaNumarasi;
                }
                return ortalama / this.FutbolcuSayisi;
            }
        }

        public Takim (params Futbolcu [] Futbolcular)
        {
            this.TakimOyunculari = Futbolcular;
        }
        public IEnumerator GetEnumerator()  // Kullanılacak... 
        {
            return new FutbolcuEnumerator(this.TakimOyunculari);
        }
    }
    class FutbolcuEnumerator :IEnumerator
    {
        // 1)Hangi dizi üzerinde dönüleceğini belirtmek için bir değişken oluşturulur..;
        private Futbolcu[] donulecek;

        //2)Dönmye kaçinci index'den başlanacak ? 
        //ilk index değerini -1 olmasının sebebi  ,Foreach 'in çalışamaya moovnext metodu  ile başlamasi prensibidir. .Move next metodu içerisinde öncellikle siradaki eleman var mi diye bakilir. eğer varsa current prop 'si harekete geçer ..
        int index = -1;


        //3)Enumerator class'ı içerisindeki donulecek adli dizinin asli nedir ? 
        // bu class'ın ctor'ı parametreli hale getir.. 

        public FutbolcuEnumerator( Futbolcu[] HangiDiziyeDoneyim)
        {
            this.donulecek = HangiDiziyeDoneyim;
        }

        //Current Prop 'si size o anda turnikeden geçen elemani verir. 
        public object Current
        {
            get
            {
           
                    
                return donulecek[index];
            }
        }

        public bool MoveNext()
        {
            //Move next metodu =>siradan bir eleman varmi yokmu diye kontrol eder.. 
            //eğer eleman varsa true döner ve döngü devam eder , false döngü biter. 
            index++;
            return this.index < donulecek.Length;
        }

        public void Reset()
        {
            //Reset metodu =>> Döngunun bittiği anda devreye gire ve turnikeyi sıfırlar.
            this.index = -1;
        }

        //current pro'si size ,o anda turnikeden geçecek olan elemani verir. 
    }
}
