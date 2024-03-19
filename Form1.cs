using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projekt2
{
    public partial class FormPrzelicznikWalut : Form
    {
        float ŻrodłowaWaluta = 0;
        float newSize = 0;
        public FormPrzelicznikWalut()
        {
            InitializeComponent();
            label_ŹródłowaWaluta.Text = "Waluta Źródłowa";
            label_DocelowaWaluta.Text = "Waluta Docelowa";
            hScrollBar1.Scroll += HScrollBar1_Scroll;
            

        }
        private bool Sprawdzenia_Numeru()
        {
            bool success = float.TryParse(textBox_ŹródłowaWaluta.Text, out ŻrodłowaWaluta);
            return success;
        }
        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (textBox_ŹródłowaWaluta.Text == string.Empty) 
            {
                textBox_ŹródłowaWaluta.Text = "" + e.NewValue;
            }

            else if (Sprawdzenia_Numeru())
            {
                ŻrodłowaWaluta-=newSize;
                newSize = e.NewValue;
                textBox_ŹródłowaWaluta.Text = "" + (ŻrodłowaWaluta + e.NewValue );
            }
            
        }

        private void radioButton_PLN_WŹ_CheckedChanged(object sender, EventArgs e)
        {
            label_ŹródłowaWaluta.Text = "PLN";

        }
        private void radioButton_USD_WŹ_CheckedChanged(object sender, EventArgs e)
        {
            label_ŹródłowaWaluta.Text = "USD";
           
        }

        private void radioButton_EURO_WŹ_CheckedChanged(object sender, EventArgs e)
        {
            label_ŹródłowaWaluta.Text = "EURO";
            
        }

        private void radioButton_IN_WŹ_CheckedChanged(object sender, EventArgs e)
        {
            label_ŹródłowaWaluta.Text = "IN";
            
        }

        private void radioButton_PLN_WD_CheckedChanged(object sender, EventArgs e)
        {
            label_DocelowaWaluta.Text = "PLN";
            
        }

        private void radioButton_USD_WD_CheckedChanged(object sender, EventArgs e)
        {
            label_DocelowaWaluta.Text = "USD";
            
        }

        private void radioButton_EURO_WD_CheckedChanged(object sender, EventArgs e)
        {
            label_DocelowaWaluta.Text = "EURO";
            
        }

        private void radioButton_IN_WD_CheckedChanged(object sender, EventArgs e)
        {
            label_DocelowaWaluta.Text = "IN";
            
        }

        public  void Kurs()
        {
            float kurs=0;
            float kursPLN=0;
            kursPLN = float.Parse(textBox_ŹródłowaWaluta.Text);

            if (label_ŹródłowaWaluta.Text == "USD")
            {
                 kursPLN  *= 3.92f;
            }
            else if(label_ŹródłowaWaluta.Text == "EURO")
            {
                kursPLN *= 4.29f;
            }
            else if (label_ŹródłowaWaluta.Text == "IN")
            {
                kursPLN *= 68940f;
            }


            if (label_DocelowaWaluta.Text == "EURO")
            {
                kurs = kursPLN * 0.22f;
            }
            else if(label_DocelowaWaluta.Text == "PLN")
            {
                kurs = kursPLN ;
            }
            else if (label_DocelowaWaluta.Text == "USD")
            {
                kurs = kursPLN *0.24f;
            }
            else if (label_DocelowaWaluta.Text == "IN")
            {
                kurs = kursPLN / 68940f;
            }
            
            textBox_DocelowaWaluta.Text  = "" + Math.Round(kurs,2);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Kurs();

        }
        private void Waluta_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Kurs();
        }

    }
}
