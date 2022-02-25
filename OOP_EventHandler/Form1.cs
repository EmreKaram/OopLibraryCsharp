using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_EventHandler.Araba;

namespace OOP_EventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            //Tipki delegete olduğu gibi  bir olayı bir metotda bağlamak için  += kullanılır. çıkarmak için ise -= ;
            //Yanlız bu noktada dikkat eidlmesi gereken durum ,olayların bağlanacağı metotların imza yapıları olayın türü  olan delege ile aynı olmalı .Burdan şu şekilde bir sonuç çıkar aslında bir event 'dan önce   mutlaka bir delege kullanmaız gerekir .
            Araba arb = new Araba(180, "Fiat");

            //  arb.HizAşimi += new HizAsimiFonks(HizLimit);
            arb.HizAşimi +=  new HizAsimiFonks(HizLimit);
                              
            HizAsimiFonks hiz;
          


            for (int i = 0; i < 10; i++)
            {
                arb.Hiz += 10;
                lstSonuc.Items.Add("Arabanın anlik hizi " + arb.Hiz);
            }

        }

 

        void HizLimit()
        {
            lstSonuc.Items.Add("Aşıyorusunuz yavaşlayınız lütfen ");
        }
    }
}
