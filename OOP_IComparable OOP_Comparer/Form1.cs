using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_IComparable_OOP_Comparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Takim> puanDurumu = new List<Takim>();
        private void ListViewDoldur()
        {
            listView1.Items.Clear();
            int siralama = 1;
            foreach (var item in puanDurumu)
            {
                ListViewItem li = new ListViewItem(siralama.ToString());
                li.SubItems.Add(item.Adi);
                li.SubItems.Add(item.Averaji.ToString());
                li.SubItems.Add(item.Puan.ToString());
                siralama++;
               listView1.Items.Add(li);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

          

            puanDurumu.Add(new Takim { Adi = "Galatasaray", Averaji = 56, Puan = 78 }); // obje 
            puanDurumu.Add(new Takim { Adi = "Beşiktaş", Averaji = 32, Puan = 54 }); //obje 
            puanDurumu.Add(new Takim { Adi = "Fenerbahçe", Averaji = 25, Puan = 32 });
            puanDurumu.Add(new Takim { Adi = "Trabzonspor", Averaji = 48, Puan = 74 });
            puanDurumu.Add(new Takim { Adi = "EskişehirSpor", Averaji = 32, Puan = 41 });
            puanDurumu.Add(new Takim { Adi = "Başakşehir", Averaji = 14, Puan = 26 });
            puanDurumu.Add(new Takim { Adi = "Bursaspor", Averaji = 36, Puan = 48 });
            puanDurumu.Add(new Takim { Adi = "AntalyaSpor", Averaji = 11, Puan = 24 });
            puanDurumu.Add(new Takim { Adi = "HataySpor", Averaji = -9, Puan = 6 });
            puanDurumu.Sort();
            ListViewDoldur();


        }

        bool PuanBuyktenKucugemi = true;
        bool AverajBuyuktenKucugemi = true;
        bool AdaGoreBuyuktenKucugemi = true;


        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 1:
                    if (AdaGoreBuyuktenKucugemi)
                    {
                        puanDurumu.Sort(new AdagoreKucuktenBuyugeDogruSiralama());
                      
                        AdaGoreBuyuktenKucugemi = false;
                    }
                    else
                    {
                        puanDurumu.Sort(new AdaGoreBuyuktenKucugeSiralama());
                        AdaGoreBuyuktenKucugemi = true;
                    }
                    break;
                case 2:
                    if (AverajBuyuktenKucugemi)
                    {
                        puanDurumu.Sort(new AverajaGoreKucuktenBuyugeSirala());
                        AverajBuyuktenKucugemi = false;
                    }
                    else
                    {
                        puanDurumu.Sort(new AverejaGoreBuyuktenKucugeSiralama());
                        AverajBuyuktenKucugemi = true;
                    }

                    break;
                case 3:
                    if (PuanBuyktenKucugemi)
                    {
                        puanDurumu.Sort(new PuaniKucuktenBuyugeSiralama());
                        PuanBuyktenKucugemi = false;
                    }
                    else
                    {
                        puanDurumu.Sort();
                        PuanBuyktenKucugemi = true;
                    }

                    break;
            }

            ListViewDoldur();
        }
    }
}
