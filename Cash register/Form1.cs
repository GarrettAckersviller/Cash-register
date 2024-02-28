using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_register
{
    public partial class Form1 : Form
    {
        double burgerPrice = 1;
        double drinkPrice = 0.75;
        double fryPrice = 0.25;
        double burgerNumber;
        double drinkNumber;
        double fryNumber;
        double subtotal;
        double taxRate = 0.13;
        double taxAmount;
        double totalPrice;
        double change;
        double tenderdAmount;
        double printRecipt;
        double burgers;
        double drinks;
        double fries;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                burgerNumber = Convert.ToDouble(Burgernumbertext.Text);
                fryNumber = Convert.ToDouble(Friesnumbertext.Text);
                drinkNumber = Convert.ToDouble(Drinksnumbertext.Text);
                subtotal = burgerPrice * burgerNumber + fryPrice * fryNumber + drinkPrice * drinkNumber;
                taxAmount = subtotal * taxRate;
                totalPrice = subtotal + taxAmount;

                subtotallabel.Text = $"{subtotal.ToString("C")}";
                taxlabel.Text = $"{taxAmount.ToString("C")}";
                totallabel.Text = $"{totalPrice.ToString("C")}";

                Calculatechange.Enabled = true;
            }

            catch
            {
                subtotallabel.Text = "error";
                taxlabel.Text = "error";
                totallabel.Text = "error";
            }


        }

        private void Calculatechange_Click(object sender, EventArgs e)
        {

            try
            {
                tenderdAmount = Convert.ToDouble(Tenderdtext.Text);
                change = tenderdAmount - totalPrice;

                changelabel.Text = $"{change.ToString("c")} ";

                print.Enabled = true;
            }

            catch
            {
                changelabel.Text = "error";   
            
            }
            
        }

        private void print_Click(object sender, EventArgs e)
        {

            receiptlabel.Text = "McDaniels";
            this.Refresh();
            Thread.Sleep(1000);
            receiptlabel.Text += $"\n\n {burgerNumber} burgers @      {burgerPrice.ToString("C")}";
            this.Refresh();
            Thread.Sleep(1000);
            receiptlabel.Text += $"\n\n {fryNumber} frys @         {fryPrice.ToString("C")}";
            this.Refresh();
            Thread.Sleep(1000);
            receiptlabel.Text += $"\n\n {drinkNumber} drinks @       {drinkPrice.ToString("C")}";
            this.Refresh();
            Thread.Sleep(1000);
            receiptlabel.Text += $"\n\nsubtotal:         {subtotal.ToString("C")}";
            this.Refresh();
            Thread.Sleep(1000);
            receiptlabel.Text += $"\n\ntaxAmount:        {taxAmount.ToString("C")}";
            this.Refresh();
            Thread.Sleep(1000);
            receiptlabel.Text += $"\n\ntotalPrice:       {totalPrice.ToString("C")}";
            this.Refresh();
            Thread.Sleep(1000);
            receiptlabel.Text += $"\n\nchange:           {change.ToString("C")}";

            SoundPlayer player = new SoundPlayer(Properties.Resources.Dot_Matrix_Printer_SoundBible_com_790333844);

            player.Play();






        }

        private void neworder_Click(object sender, EventArgs e)
        { // Resets verything
            receiptlabel.Text = "";
            changelabel.Text = "";
            totallabel.Text = "";
            taxlabel.Text = "";
            subtotallabel.Text = "";
            Tenderdtext.Text = "";
            Drinksnumbertext.Text = "";
            Friesnumbertext.Text = "";
            Burgernumbertext.Text = "";


        }
    }
}
