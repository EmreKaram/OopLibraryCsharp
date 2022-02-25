using System;
using System.Collections;
//class ekledik fakat formda yoktu .Dersde unutuldu. İmplement edildi diye düşünülerek bakılmadi
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEnumerable__IEnumerator_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Futbolcu f1 = new Futbolcu { AdiSoyadi = "Muslera ", FormaNumarasi = 25, Mevkisi = Mevkiiler.Kaleci };
            Futbolcu f2 = new Futbolcu { AdiSoyadi = "Bekir irtegün", FormaNumarasi = 3, Mevkisi = Mevkiiler.Defans };
            Futbolcu f3 = new Futbolcu { AdiSoyadi = "Sabri Sarıoğlu", FormaNumarasi = 55, Mevkisi = Mevkiiler.OrtaSaha };
            Futbolcu f4 = new Futbolcu { AdiSoyadi = "Gomis", FormaNumarasi = 85, Mevkisi = Mevkiiler.Forvet };

            Takim yildizlarkarmasi = new Takim(f1,f2,f3,f4);

            //foreach (var item in yildizlarkarmasi)
            //{
            //    lstTopcular.Items.Add(item.ToString());
            //}


            IEnumerator sayac = yildizlarkarmasi.GetEnumerator();
            while (sayac.MoveNext())
            {
                lstTopcular.Items.Add(sayac.Current);
            }

            MessageBox.Show("bU TAKIMDA toplam "+ yildizlarkarmasi.FutbolcuSayisi+"oyuncu vardir.");
            MessageBox.Show("Takimdaki oyuncularin forma numarasi ortalamasi =>> "+ yildizlarkarmasi.FormaNumaraOrtalamasi);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
