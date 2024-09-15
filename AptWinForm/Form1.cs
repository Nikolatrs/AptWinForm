using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace AptWinForm
{
    public partial class Form1 : Form
    {

        public Form1(int v)
        {
            InitializeComponent();
            LableChenge.LableToForm = output;

            button1.Text = "добавить надпись";
            button1.Click += Button1_Click;
            button2.Text = "добавить строчку";
            button2.Click += Button1_Click;
            button3.Text = "отчистить";
            button3.Click += Button1_Click;

            info.Text = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch ((sender as System.Windows.Forms.Button).Name)
            {
                case "button1":
                    LableChenge.LableWrite(textBox1.Text);
                    break;
                case "button2":
                    LableChenge.LableWriteline(textBox1.Text);
                    break;
                case "button3":
                    LableChenge.LableClear();
                    break;
                default:
                    LableChenge.LableWrite(null);
                    break;

            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
    }
    class LableChenge
    {
        public static Label LableToForm { get; set; }

        public static void LableWriteline(string text)
        {
            if (text != null)
            {
                LableToForm.Text += $"\n{text}";
            }
            else { LableToForm.Text += null; }
        }
        public static void LableWrite(string text)
        {

            if (text != null)
            {
                LableToForm.Text += text;

            }
            else { LableToForm.Text += null; }
        }

        public static void LableClear()
        {
            LableToForm.Text = null;
        }



    }

    class ComputerClub
    {
        private List<Computer> _computers = new List<Computer>();
        private Queue<Clitnt> _clitnts = new Queue<Clitnt>();
    }
    class Computer
    {
        private Clitnt _clitnt;
        private int _minutesRemaining;
        private bool _isTaken;

        public int PricePerMinute { get; private set; }


    }

    class Clitnt
    {
        private int _money;
        public int DesuredMinutes { get; private set; }

        public Clitnt (int money, Random random)
        {
            _money = money;
            DesuredMinutes = random.Next(20,30);
        }
    }
}
