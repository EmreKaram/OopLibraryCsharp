using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            foreach (var item in Enum.GetNames(typeof(Departmanlar)))
            {
                comboBox1.Items.Add(item);
            }


        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            //Personel p = new Personel();
            //p.AdiSoyadi = "Ahmet Tas";
            //p.Departman = Departmanlar.Yazilim;


            Personel p = new Personel();
            p.AdiSoyadi = txtPersonelAdi.Text;
            p.Departman=(Departmanlar)Enum.Parse(typeof(Departmanlar),comboBox1.Text);

            int secilenEnumunIndexi = (int)Enum.Parse(typeof(Departmanlar), comboBox1.Text);

            Departmanlar cıkacak;
            bool sonuc = Enum.TryParse<Departmanlar>(comboBox1.Text,out cıkacak);

            if (sonuc)
            {
                MessageBox.Show("Personel Departmani => " + cıkacak.ToString());
            }
            else
            {
                MessageBox.Show("Uygun Departman seçmedin gibi neler oluyor ?");
            }

            switch (p.Departman)
            {
                case Departmanlar.Yazilim:
                    MessageBox.Show("Hoşgeldin ,Yazılımcı ...");
                    break;
                case Departmanlar.SistemAgUzmanlıgı:
                    break;
                case Departmanlar.GrafikTasarim:
                    break;
                case Departmanlar.Office:
                    break;
                case Departmanlar.Muhasebe:
                    break;
                case Departmanlar.İnsanKaynaklari:
                    break;
                case Departmanlar.ERP:
                    break;
                default:
                    break;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
         //   comboBox1.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));
          //  comboBox1.SelectedIndex = 0;


        }

        ///Enum 
        ////Kisilere sabit seçenekler sunmak için kullanılan bir değer tipidir.Seçenkleri kontrol altında tutup  ,uygulamanizda kendi kontrolünüz içeriside yönetebilirisiniz. Bu seble uygulamanizda herhangi bir süprize yer vermezsiniz. ve çok daha performansli aynı zamanda çok daha güvenlir bir yapı oluşturursunuz.. .
        ///Enumlar tamamı ile  geliştişrici yönelik nesnelerdir. .
        /////  Enum.GetNames() =>> Bir enumun yazilini değerini  teslim almanızı sağlar.. 
        //Yazili hele getirilmiş  bir enum değerini ,Tekrar dan enum  şekline geri almak isterseniz. Enum.parse  fonksiyonu kullanılır.
        //Bir enum değeri arkasında sayısal değer tutar .Bu değerler varsayılan olarak seçilen değlerin  index değeridir VE veri tipi int 'dir . Ancak siz isterseniz bu tipi değiştirebilirisiniz (sbyte,byte, short, unit, long , ulong) yapabilirsiniz. 
        //Başlangıç değerini el ile manuel belirtebilirisiniz. (yada bütün enum değerlerine el ile tek tek değer atayabilirisiniz. )


    }
}
