using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls) { c.Visible = true;}
            
            var nfi = new NumberFormatInfo { NumberDecimalSeparator = ",", NumberGroupSeparator = "." };

            string coinsS = txtBox_coins.Text.Replace(".", ",");
            string priceS = txtBox_price.Text.Replace(".", ",");

            double.TryParse(coinsS, out double coins);
            double.TryParse(priceS, out double price);

            double rezultat = coins * price;
            label_currentMoney.Text = rezultat.ToString("#,##0") + " $";

            rezultat = coins * 0.00001;
            lbl_4.Text = rezultat.ToString("#,##0", nfi) + " $";

            rezultat = coins * 0.0001;
            lbl_3.Text = rezultat.ToString("#,##0", nfi) + " $";

            rezultat = coins * 0.001;
            lbl_2.Text = rezultat.ToString("#,##0", nfi) + " $";

            rezultat = coins * 0.01;
            lbl_1.Text = rezultat.ToString("#,##0", nfi) + " $";

            rezultat = coins * 0.1;
            lbl_0.Text = rezultat.ToString("#,##0", nfi) + " $";

            rezultat = coins * 1;
            lbl_dolar.Text = rezultat.ToString("#,##0", nfi) + " $";

            rezultat = coins * 10;
            lbl_10.Text = rezultat.ToString("#,##0", nfi) + " $";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void txtBox_coins_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_Calculate_Click(sender, e); 
        }
    }
}
