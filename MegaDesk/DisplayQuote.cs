using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {

        public DisplayQuote(string text1, string text2, string text3, string text4, object selectedItem, string text5, string text6)
        {
            InitializeComponent();
            label7.Text = text1;
            label8.Text = text2;
            label9.Text = text3;
            label10.Text = text4;
            label11.Text = selectedItem.ToString();
            Date.Text = text5;
            label12.Text = text6;

        }

    }
}
