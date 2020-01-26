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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();

        }

        private void WidthBox_Validating(object sender, CancelEventArgs e)
        {

            if (double.TryParse(WidthBox.Text, out double value))
            {
                if (value < 24 || value > 96)
                {
                    WidthBox.ForeColor = Color.Red;
                    WarningText.Text = "Width must be between 24 and 96";
                }
                else
                {
                    WidthBox.ForeColor = Color.Green;
                    WarningText.Text = "";

                }
            }
            else
            {
                WidthBox.ForeColor = Color.Red;
                WarningText.Text = "Width must be a number between 24 and 96";

            }


        }

        private void DepthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                if (!char.IsDigit(e.KeyChar))
                {
                    DepthBox.ForeColor = Color.Red;
                    WarningText.Text = "Depth must be a digit";
                    DepthBox.Text = "";

                }
                  
                else
                {
                DepthBox.ForeColor = Color.Green;

                WarningText.Text = "";

            }


        }
    }
}
