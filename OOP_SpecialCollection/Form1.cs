using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SpecialCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHashTable_Click(object sender, EventArgs e)
        {
            //system.collections


            //Anahtar -değer ikili mantığı ile  (key -value pair) çalışan özel bir koleksiyon tipidir. 
            //hashtable veri olarak anahta değer kisminda object tipinde veri alır. 
            //Genellikle büyük boyutlu  kolleksiyonlar için kullanılmaktadır. 
            //Hashtable ,içerisindeki değerleri ram'deki referasn numararalarına göre sıralanır... 
            //Buarada hashtable key -value mantığı  unique olma zorunluluğu varıdr. kULLANILAN DEĞERİ BİR DAHA KULLANAMZSINIZ. 
            



            Hashtable anahtardegerdizi = new Hashtable();
            //anahtardegerdizi.Add("isim", "mehmet");
            //anahtardegerdizi.Add("sayi", 15);
            //anahtardegerdizi.Add("form", new Form { Width = 300, Height = 300 });

            //((Form)anahtardegerdizi["form"]).Show();

            anahtardegerdizi.Add(7, "James Bond");
            anahtardegerdizi.Add(10, "Messi");
            anahtardegerdizi.Add(55, "sabri");
            anahtardegerdizi.Add(78, "test");

            //HASHTABLE İÇERİSİNDEKİ BİR VALUE 'ÇEKMEK İÇİN YAPMANIZ GEREKEN  KÖŞELİ PARANTEZ İÇERİSİNDEKİ O DEĞERİ TAŞIAYAN ANAHTARİ VERMEK OLACAKTIR .
            MessageBox.Show(anahtardegerdizi[55].ToString()) ;

           // anahtardegerdizi.Remove(55); // =>> 55 ANAHATARİNA SAHİOP ELEMANİ DİZİDEN KALDİRİR. 
            if (anahtardegerdizi.ContainsKey(55))
            {
                MessageBox.Show("Zaten  var");
            }
            else
            {
                anahtardegerdizi.Add(55, "Test");
            }


            foreach (var item in anahtardegerdizi.Keys)
            {
                listBox1.Items.Add(string.Format("Anahtar : {0} - değer {1}", item, anahtardegerdizi[item]));
            }
           


        }

        private void btn_listDicttionary_Click(object sender, EventArgs e)
        {
            // Tıpkı hasth table gibi key value mantığı ile çalışan başka bir yapıdır. 
            ListDictionary anahtardegerdizis2 = new ListDictionary();
            anahtardegerdizis2.Add(1, "İstanbul");
            anahtardegerdizis2.Add(2, "Ankara");
            anahtardegerdizis2.Add(3, "İzmir");
            anahtardegerdizis2.Add(4, "Bursa");
            anahtardegerdizis2.Add(5, "İzmit");
            anahtardegerdizis2.Add(6, "Bolu");
            anahtardegerdizis2.Add(7, "Karabük");
            anahtardegerdizis2.Add(8, "Malatya");
            anahtardegerdizis2.Add(9, "Burdur");
            anahtardegerdizis2.Add(10, "Şırnak");
            anahtardegerdizis2.Add(11, "Manisa");
            anahtardegerdizis2.Add(12, "Adiyaman");


            foreach (var item in anahtardegerdizis2.Keys) 
            {
                listBox1.Items.Add(string.Format("Anahtar : {0} - değer {1}", item, anahtardegerdizis2[item]));
            }

        }

        private void btnHybridDictionry_Click(object sender, EventArgs e)
        {
            //Hashtable  ve listdict. mantığı ile  key value olarak çalışır. 
            //Ancak microsoft .doc   koleksiyon küçükse listdic gibi davranır. eleman sayisi 10 ve üzeri ise hashtable 'la döner. ..
            //Burada kullanımın durumunuza göre yapacağınız doğru bir kolleksiyon seçime tabiyki  perofrmnas olarak sizlere geri dönecektir. .

            HybridDictionary test = new HybridDictionary();
            test.Add(1, "İstanbul");
            test.Add(2, "Ankara");
            test.Add(3, "İzmir");
            test.Add(4, "Bursa");
            test.Add(5, "İzmit");
            test.Add(6, "Bolu");
            test.Add(7, "Karabük");
            test.Add(8, "Malatya");
            test.Add(9, "Burdur");
            test.Add(10, "Şırnak");
            test.Add(11, "Manisa");
            test.Add(12, "Adiyaman");


            foreach (var item in test.Keys)
            {
                listBox1.Items.Add(string.Format("Anahtar : {0} - Değer {1}", item, test[item]));
            }
        }
    }
}
