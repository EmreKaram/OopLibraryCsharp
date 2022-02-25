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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        enum Sehirler
        {
            Ankara =6,
            İstanbul =34,
            Adana=1,
            İzmir=35,
            Malatya=44
        }

        private void btnEnumDeger_Click(object sender, EventArgs e)
        {
          int enumDeger = int.Parse( txt_Enum.Text);

            Sehirler sehir =  (Sehirler)enumDeger ;
            MessageBox.Show(sehir.ToString()); ;
        }

        private void btnKontrolluEnum_Click(object sender, EventArgs e)
        {
            //Textbox üzerinden index numarası girilidğinde enum değeri teslim edilsin .var olmayan bir index girilidğinde  index numarsı geriye teslim edilsin 


            //Enum içerisinde  var olan bir değerin kontrolünü sağlamak için bir metot var . bu metotdu bul ve yukarda yaptığın işlemlerin aynısını burada kontrollü yap . IsDefined 
            int  enumDeger = Convert.ToInt32(txt_Enum.Text);
            bool result = Enum.IsDefined(typeof(Sehirler), enumDeger);
            if (result)
                
            {
                Sehirler sehir = (Sehirler)enumDeger;
                MessageBox.Show(sehir.ToString()) ;
            }
            else
            {
                MessageBox.Show("Girdiğin index numarası hatalıdır .");
            }


            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(Sehirler)))
            {
                listBox1.Items.Add(item + "-" + Convert.ToInt32(Enum.Parse(typeof(Sehirler), item)));
            }
        }
    }
}
