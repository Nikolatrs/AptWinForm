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

        public Form12(int v)
        {
            InitializeComponent();
            addXML.Click += addXML_Click;
            reset.Click += Reset_Click;

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
        private void addXML_Click(object sender, EventArgs e)
        {
            Pharmacy myAPT = new Pharmacy(NameAPT.Text,Server.Text,IP.Text);
            ListViewItem
            list.AutoCompleteCustomSource.Add(NameAPT.Text.ToString());

        }
    }



}
