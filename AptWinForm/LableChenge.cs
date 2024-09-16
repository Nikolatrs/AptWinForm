using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptWinForm
{
    class TextBoxChenge
    {
        public static TextBox TextBoxToForm { get; set; }

        public static void LableWriteline(string text)
        {
            if (text != null)
            {
                TextBoxToForm.Text += $"\n{text}";
            }
            else { TextBoxToForm.Text += null; }
        }
        public static void LableWrite(string text)
        {

            if (text != null)
            {
                TextBoxToForm.Text += text;

            }
            else { TextBoxToForm.Text += null; }
        }

        public static void LableClear()
        {
            TextBoxToForm.Text = null;
        }
    }
}
