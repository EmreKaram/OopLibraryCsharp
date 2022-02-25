using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.ReferanceAndValueType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //.net mantık gereği , uygulama üzerinde gecici olarak kullanılan tüm nesneler  ram  üzerinde kendilerine bir yer edinirler .
        //Ram teknik yapsınında inclendiğinde  iki farklı blok vardı .. 
        // stack bolumunde "Value type" olarak isimlendiridiğimiz  değer tipleri tutarız. . 
        //(string hariç tüm değişkenler , Enum,Struct)
        // heapde değer tutanlarde "Referance type " olarak isimlendirilirdi.  (class,delefate,array,string)
        //value type 'ların değer kopyalama özelliği sahipken ,redeferasnlarda bu olaya değer taşıma denir.. 

        //Bir değerin null olması demek , odeğerin heap de  karşılının olmaması demektir.
        //Dolayısı ile reference tipler null geçilebilirken  değer tipler null geçilemezler .



        // Not: Value type  valure tipindekiş bir nesne tüm veriyi kendi içinde tutarç 
        /// direkt ıolarak veyi tutmaz bunun yerine adresini tutar ..
        /// 

        class Ogrenci 
        {
            private string adi;

            public string Adi
            {
                get { return adi; }
                set { adi = value; }
            }

            private string soyadi;

            public string Soyadi
            {
                get { return soyadi; }
                set { soyadi = value; }
            }

        }

        struct Student
        {
            // Sturct (Yapi ) =>> En basit olarak şu şekilde tanımalana bilir .. classlarin değer tipi (value type versiyonlarıdır)
            // struct 'larla classlar arasındaki en büyük farklardan bir tanesi sturct 'lar  başka bir sturct 'tan  yada herhangi bir classdan kalitim alamazlar. . (sadece ve sadece interface implement edilebilir.. )

            //Eğer bir gün olurda struct mı kullanıyım yoksa class mı derseniz  ??
            //değer tip referans tip olması bakımından  bir problem teşkil etmiyorsa  16 kb'dan büyük nesnler içic class , kücük nesnler ,için ise struct  kullanılması düşünülebilir. 


            public string FirstName { get; set; }
            public string LastName { get; set; }



        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.FirstName = "Mehmet";
            st.LastName = "Tas";

            Student st2 = st;
            st2.FirstName = "Yasin";
            MessageBox.Show(st.FirstName);


            MessageBox.Show(st.GetHashCode() + "\n" + st2.GetHashCode()) ;

            //int a = 5;
            //int b = a;
            //b = b + 10;
            //MessageBox.Show(a.ToString());



            //Aşağıdaki array olduğu için buda reference type olduğu için 24 'dür. .
            int[] sayilar = { 12, 15, 16 };
            int[] sayilar_2 = sayilar;
            sayilar_2[1] = 24;
            MessageBox.Show(sayilar[1].ToString());


        }

        private void btn_Reference_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Bilge";
            ogr.Soyadi = "Adam";

            Ogrenci ogr2 = ogr;
            ogr2.Adi = "Recep";

            MessageBox.Show(ogr.Adi);
            MessageBox.Show(ogr.GetHashCode() + "\n" + ogr2.GetHashCode());


            //Hash codu gethascode ile öğrenilir. 
            //Web sitlerinde "hash" leme yöntemi ile girdiğiniz /gönderdiğiniz yada aldığınız  veriler şifrelenir.. 
          
        }
    }
}
