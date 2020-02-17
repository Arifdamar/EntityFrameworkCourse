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
            VTContext vt = new VTContext();

            var urunler = vt.Urunler.OrderByDescending(i => new { i.UrunAdi, i.Fiyat })
                .Take(5)
                .ToList();

            foreach (var item in urunler)
            {
                Console.WriteLine("Urun adı: {0} fiyat: {1}", item.UrunAdi, item.Fiyat);
            }


            Console.ReadLine();
        }
    }
}
