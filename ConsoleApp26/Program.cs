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

            var urunler = vt.Urunler.ToList();

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Fiyat);
            }

            foreach (var urun in urunler)
            {
                urun.Fiyat *= 1.25;
            }
            vt.SaveChanges();

            Console.WriteLine("------------------------------------");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Fiyat);
            }












            //var kategori = vt.Kategoriler.Where(i => i.Id == 1).FirstOrDefault();

            //if (kategori != null)
            //{
            //    kategori.KategoriAdi = "Telefonlar";
            //    vt.SaveChanges();
            //}

            //foreach (var item in vt.Kategoriler)
            //{
            //    Console.WriteLine(item.KategoriAdi);
            //}

            Console.ReadLine();
        }
    }
}
