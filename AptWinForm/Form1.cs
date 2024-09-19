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
    public partial class Form12 : Form
    {
        Pharmacies pharmaciesList = new Pharmacies();
        //ListViewItem APTItem = new ListViewItem();

        public Form12(int v)
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            add.Click += addToSource_Click;
            reset.Click += Reset_Click;
            EntrAPT.Click += EntrAPT_Click;
            EntrAPT.Enter += EntrAPT_Enter;


        }

        private void EntrAPT_Enter(object sender, EventArgs e)
        {
            if (EntrAPT.Text != null)
            {
                NameAPT.Text =  ;
            }
        }


        private void EntrAPT_Click(object sender, EventArgs e)
        {
            EntrAPT.SelectAll();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            NameAPT.Clear();
            Server.Clear();
            IP.Clear();
        }
        private void addToSource_Click(object sender, EventArgs e)
        {
            Pharmacy myAPT = new Pharmacy(NameAPT.Text,Server.Text,IP.Text);
            ListViewItem APTItem = new ListViewItem(myAPT.PhName);
            APTItem.Text = myAPT.PhName;
            APTItem.Tag = myAPT;

            pharmaciesList.PharmacyList.Add(myAPT);


            EntrAPT.AutoCompleteCustomSource.Add(APTItem);

        }

    }



}
