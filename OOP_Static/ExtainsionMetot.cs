using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace OOP_Static
{
  static public  class ExtainsionMetot
    {
        public static string MetinTemizle(this string param)
        {
            param = param.ToLower().Replace("ş", "s").Replace("ü", "u").Replace("ç", "c").Replace("ö", "o").Replace("ı", "i").Replace("ğ", "g");


            //ToTitleCase metin içerisinde yer alan her kelimenin ilk karakterini büyük yapar.
            return CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(param);



        }
    }
}
