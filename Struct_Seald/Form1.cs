using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct_Seald
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Struct yapılarda boş yapıcı metot oluşturuladığından dolayı ,new anahtar kelimesi kullanılma zorunluluğu yoktur. 


        Kitap k;
        private void Form1_Load(object sender, EventArgs e)
        {
            k.Adi = "Test1";
            k.Turu = "Test2";
            k.YazarAdi = "test3";
            k.ISBNNO = "564546454";


            Kitap kitap = new Kitap();
            kitap.Adi = "Test3";
            kitap.Turu = "Test3";
            kitap.YazarAdi = "Test3";
            kitap.ISBNNO = "4564564";


            Kitap kitap1 = new Kitap(1, "asdasd", "sadasd", "545454", "sadasdas");






        }
    }
}
