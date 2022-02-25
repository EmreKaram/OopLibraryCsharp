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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //enum Sehirler
        //{
        //    İstanbul,Ankara,İzmir,Bursa,Eskişehir
        //}

        //enum Sehirlerr
        //{
        //    İstambul=10 ,Ankara,İzmir,Manisa ,Bursa
        //}

        //enum Sehirlerrr
        //{
        //    istanbul=34, Ankara=06, izmir=35 ,bursa=16,Edirine = 22
        //}

        enum Sehirler:byte
        {
                istanbul 
                ,Ankara
                ,İzmir
                ,Manisa 
                ,Eskisehir
        }
        private void btnİslemYap_Click(object sender, EventArgs e)
        {
            //int secilenIndex = (int)Enum.Parse(typeof(Sehirler), listBox1.Text);
          byte seciliindex=  (byte)Enum.Parse(typeof(Sehirler), listBox1.Text);
            MessageBox.Show("Seçili şehrin indexi => "+ seciliindex);

           Sehirler gelen  = (Sehirler) Enum.Parse(typeof(Sehirler), "2");


        }

        private void Form2_Load(object sender, EventArgs e)
        {
              listBox1.Items.AddRange(Enum.GetNames(typeof(Sehirler)));
        }
    }
}
