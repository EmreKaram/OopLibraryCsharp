using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFABilgeBurger
{
    public static class Fonksiyon
    {
        public static  void Temizle(Control.ControlCollection kolleksiyon )

        {
            foreach ( Control  item in kolleksiyon)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();

                }
                else if (item is CheckBox)
                {
                    CheckBox chc = (CheckBox)item;
                    chc.Checked = false;
                }
                else if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    if (rb.Name== "rbKucuk")
                    {
                        rb.Checked = true;
                    }
                    else
                    {
                        rb.Checked = false;
                    }
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nmr = (NumericUpDown)item;
                    nmr.Value = 1;
                }
                else if (item is GroupBox)
                {
                    GroupBox gb = (GroupBox)item;
                    Temizle(gb.Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel  flp = (FlowLayoutPanel)item;
                    Temizle(flp.Controls);
                }

                else if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    cb.SelectedIndex = 0;
                }

            }
        }
    }
}
