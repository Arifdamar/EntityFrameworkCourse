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

            /*
            List<Kategori> kategoriler = context.Kategoriler.ToList();
            var kategoriler = context.Kategoriler.ToList();
            
            foreach (var kategori in kategoriler)
            {
                Console.WriteLine("Kategori Id: {0} \nKategori Adı: {1}", kategori.Id,kategori.KategoriAdi);
                Console.WriteLine("--------------------------------------------------------");
            }

            var urunler = context.Urunler.ToList();
            
            foreach (var urun in urunler)
            {
                Console.WriteLine("Urun Id: {0} \nUrun Adı: {1}\nUrun Stok Adeti: {2}", urun.Id, urun.UrunAdi,urun.StokAdet);
                Console.WriteLine("--------------------------------------------------------");
            }
            */


            /*
            var urun = context.Urunler.Find(1);

            Console.WriteLine("Urun Id: {0} \nUrun Adı: {1}\nUrun Fiyat: {2}", urun.Id, urun.UrunAdi, urun.Fiyat);

            urun.Fiyat *= 1.5;
            urun.UrunAdi = "Samsung Galaxy S4";
            urun.StokAdet += 100;

            context.SaveChanges();

            urun = context.Urunler.Find(1);

            Console.WriteLine("Urun Id: {0} \nUrun Adı: {1}\nUrun Fiyat: {2}", urun.Id, urun.UrunAdi, urun.Fiyat);
            */


            /*
            var urunler = context.Urunler.ToList();
            foreach (var urun in urunler)
            {
                Console.WriteLine("Urun Id: {0} \nUrun Adı: {1}\nUrun Fiyat: {2}", urun.Id, urun.UrunAdi, urun.Fiyat);
                Console.WriteLine("---------------------------------------------");
            }

            foreach (var urun in urunler)
            {
                urun.Fiyat *= 1.25;
            }

            context.SaveChanges();
            
            urunler = context.Urunler.ToList();
            foreach (var urun in urunler)
            {
                Console.WriteLine("Urun Id: {0} \nUrun Adı: {1}\nUrun Fiyat: {2}", urun.Id, urun.UrunAdi, urun.Fiyat);
                Console.WriteLine("---------------------------------------------");
            }
            */

            var urun = context.Urunler.Find(1);

            if(urun != null)
            {
                context.Urunler.Remove(urun);
            }
            else
            {
                Console.WriteLine("Urun bulunamadı...");
            }

            context.SaveChanges();

            var urunler = context.Urunler.ToList();
            foreach (var item in urunler)
            {
                Console.WriteLine("Urun Id: {0} \nUrun Adı: {1}", item.Id, item.UrunAdi, item.Fiyat);
                Console.WriteLine("---------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
