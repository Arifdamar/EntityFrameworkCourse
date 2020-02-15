using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ (language integrated query)

            VTContext context = new VTContext();

            List<Urun> urunler = new List<Urun>()
            {
                new Urun() { UrunAdi = "Samsung S7", Fiyat = 4000, StokAdet = 350, Satistami = true },
                new Urun() { UrunAdi = "Samsung S7+", Fiyat = 4500, StokAdet = 250, Satistami = true },
                new Urun() { UrunAdi = "Samsung S8", Fiyat = 5000, StokAdet = 450, Satistami = true },
                new Urun() { UrunAdi = "Samsung S8+", Fiyat = 4500, StokAdet = 650, Satistami = false },
                new Urun() { UrunAdi = "Samsung S9", Fiyat = 6000, StokAdet = 950, Satistami = true }
            };


            foreach (var urun in urunler)
            {
                context.Urunler.Add(urun);
            }
            
            context.SaveChanges();

            Console.WriteLine("Veriler Kaydedildi...");

            Console.ReadLine();
        }
    }
}
