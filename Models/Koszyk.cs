using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    class Koszyk
    {
        public List<Product> Products { get; set; }

        public Koszyk()
        {
            Products = new List<Product>();
        }

        public void Dodaj(Product produkt, int ilosc)
        {
            for(int i = 1; i <= ilosc; i++) 
            {
                Products.Add(produkt);
            }
        }
    }

    static class Kalkulator
    {
        public static decimal koszty(this Koszyk kosz) => kosz.Products.Sum(x => x.Price);

        public static decimal kosztyPoRabacie(this Koszyk kosz)
        {
            decimal koszt = kosz.koszty();
            if (kosz.Products.GroupBy(x => x.Category).Distinct().Count() > 2)
                return koszt * 0.9m;
            return koszt;
        }
    }
}
