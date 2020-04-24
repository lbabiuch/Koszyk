using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Koszyk kosz = new Koszyk();
        private Product aktualny;
        private readonly ProductService productservice = new ProductService();

        public Form1()
        {
            InitializeComponent();
            koszyk.Load("https://cdn.pixabay.com/photo/2017/01/05/19/10/cart-1956097_960_720.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wybierzProdukt(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wybierzProdukt(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wybierzProdukt(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wybierzProdukt(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wybierzProdukt(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            wybierzProdukt(5);
        }
        private void wybierzProdukt (int number)
        {
            aktualny = productservice.Products[number];
            productUserControl1.Update(aktualny);
        }

        private void koszyk_Click(object sender, EventArgs e)
        {
                int ile = Convert.ToInt32(ilosc.Text);
                kosz.Dodaj(aktualny, ile);
                licznik();
        }

        private void licznik()
        {
            koszt.Text = "Cena: " + kosz.kosztyPoRabacie().ToString() + "€";
        }
    }
}
