using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void Log(string mesaj);

        public void SmsLog(string mesaj)
        {
            label1.Text = mesaj;
        }
        public void MailLog(string mesaj)
        {
            label2.Text = mesaj;
        }    
        public void XmlLog(string mesaj)
        {
            label3.Text = mesaj;
        }
        public void DbLog(string mesaj)
        {
            label4.Text = mesaj;
        }
    



        private void btnLog_Click(object sender, EventArgs e)
        {
            Log logger = new Log(SmsLog);
            logger += MailLog;
            logger += XmlLog;
            logger += DbLog;
            logger.Invoke("Mehaba Dünya");

            


        }
        //Delegate 
        //Bir olay gerçekleştiğinde birden fazla fonksiyonu  çağırmak istediğinizi düşünün. 
        //Öğreniğin bir düğmeye tıklanıldığında birden fazla metot otomatik olarak çağrılsın istiyor isek .Bu gibi durumlarda delegate  kullanılır. Amacımız bşr olay olduğunda  birden fazla yere bu olayı bildirmek .Bu olaylar ile ilgilenen yapıyı kurmak için delegete yapsısı kullanılır. 

        //yada 
        //temsici olarak adlanadırılan bu yapılar. projeyi asıl ayakta tutan nesneleri yormak yerine onların işlerinide üzerine alarak gerçekeştirilmesinden sorumlu olan yapılarıdır ..Bu sayede uygulamarımın her bir kolu ne tetiklendiğinde n eiş yapılacağını bilir ve üzerine düşen görevi eksiksiz tam bir şekilde gerçkelştirir. 
        //Bilmeniz gerekn diğer önemli husus ise delegeler de birer class'dır.

        //Delege nedir ?
        //1) Öncelikle delege tanımlanır. 
        //2)Delegenin çalışması durumunda sorumlu olan metotlar yazılır .
        //3)Delege 'instance anlındığında ki anda ilgili metot delegeye bağlanır   ve metot yerine invoke () metodu çağrılırçç
    }
}
