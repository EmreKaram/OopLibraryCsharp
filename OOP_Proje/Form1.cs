using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        #region PersonelEklemeMetodu

        Personel PersonelDoldur (Personel p  )
        {
            p.Ad = TxtAd.Text;
            p.Soyadi = txtSoyad.Text;
            p.TCKN = txtTcKimlikNo.Text;
            p.DogumTarihi = dtDogumTarih.Value;
            p.Telefon = txtTel.Text;
            p.Mail = txtEmail.Text;
            p.Adres = txtAdres.Text;
            p.IseGirisTarhi = dtisegiristarihi.Value;
            p.Unvan = (Unvan)Enum.Parse(typeof(Unvan), cmbUnvan.Text);
            if (pictureBox1.Tag !=null)
            {
                p.PersonelResmi = Guid.NewGuid() + pictureBox1.Tag.ToString();

                //Bin//debug// içerisinde images oluştur ..
                pictureBox1.Image.Save(Application.StartupPath + "/Images/" + p.PersonelResmi);
            }

            return p;

        }
        #endregion
        #region ListViewDoldur
    
        ListViewItem listViewDoldur(Personel p)
        {
            ListViewItem lvi = new ListViewItem(p.TCKN);
            lvi.SubItems.Add(p.Ad);
            lvi.SubItems.Add(p.Soyadi);
            lvi.SubItems.Add(p.IseGirisTarhi.ToString());
            lvi.SubItems.Add(p.Telefon);
            lvi.SubItems.Add(p.Mail);
            lvi.Tag = p;
            return lvi;
        }

        #endregion

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Personel Resmi (pnh,fpg,gif)|*.png;*.jpg;*.gif;";
            DialogResult dr = ofd.ShowDialog();
            if (dr==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.Tag = Path.GetExtension(ofd.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));

        //    notifyIcon1.ShowBalloonTip(5000, "test", "test1", ToolTipIcon.Warning);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
             p=  PersonelDoldur(p);
            ListViewItem lvi = listViewDoldur(p);
            listView1.Items.Add(lvi);
            Metot.Temizle(groupBox1.Controls);
        }

        Personel Guncellenecek;
        int indexNo;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
           indexNo= listView1.SelectedItems[0].Index;
           Guncellenecek = (Personel)listView1.SelectedItems[0].Tag;
            TxtAd.Text = Guncellenecek.Ad;
            txtAdres.Text = Guncellenecek.Adres;
            txtEmail.Text = Guncellenecek.Mail;
            txtSoyad.Text = Guncellenecek.Soyadi;
            txtTcKimlikNo.Text = Guncellenecek.TCKN;
            txtTel.Text = Guncellenecek.Telefon;
            dtDogumTarih.Value = Guncellenecek.DogumTarihi;
            dtisegiristarihi.Value = Guncellenecek.IseGirisTarhi;
            cmbUnvan.Text = Guncellenecek.Unvan.ToString();
            if (!string.IsNullOrWhiteSpace(Guncellenecek.PersonelResmi))
            {
                pictureBox1.Image = Image.FromFile("Images/" + Guncellenecek.PersonelResmi);
                pictureBox1.Tag = Path.GetExtension(Guncellenecek.PersonelResmi);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           Guncellenecek= PersonelDoldur(Guncellenecek);
            listView1.Items.RemoveAt(indexNo);
            listView1.Items.Insert(indexNo, listViewDoldur(Guncellenecek));
            Metot.Temizle(Controls);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            //listView1.Items.RemoveAt(indexNo);

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
