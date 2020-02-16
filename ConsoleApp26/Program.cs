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

            var kategoriler = vt.Kategoriler
                .Select(i => new KategoriUrunModel
                {
                    KategoriAdi = i.KategoriAdi,
                    Urunler = i.Urunler.Select(j => new UrunModel
                    {
                        UrunAdi = j.UrunAdi,
                        Fiyat = j.Fiyat
                    }).ToList()
                })
                .ToList();

            foreach (var kategori in kategoriler)
            {
                Console.WriteLine("Kategori: {0}\n{{", kategori.KategoriAdi);
                foreach (var urun in kategori.Urunler)
                {
                    Console.WriteLine("    {0}", urun.UrunAdi);
                }
                Console.WriteLine("}");
            }












            //var urunler = vt.Urunler.Select(i => new UrunModel()
            //{
            //    UrunAdi = i.UrunAdi.Length > 12 ? i.UrunAdi.Substring(0,10) + "..." : i.UrunAdi,
            //    Fiyat = i.Fiyat,
            //    Kategori = i.Kategori.KategoriAdi
            //}).ToList();

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("ürün adı: {0}\nürün fiyatı: {1}\nürün kategorisi: {2}", urun.UrunAdi, urun.Fiyat, urun.Kategori);
            //    Console.WriteLine("------------------------------------------------------");
            //}




            //var urunler = vt.Urunler.Select(i => new
            //{
            //    // anonymous object
            //    i.UrunAdi,
            //    i.Fiyat,
            //    i.Kategori
            //})
            //.ToList();
            //var kategoriler = vt.Kategoriler.ToList();

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("Ürün adı: {0}\nÜrün Fiyatı: {1}\nÜrün Kategorisi: {2}", urun.UrunAdi, urun.Fiyat, urun.Kategori.KategoriAdi);
            //    Console.WriteLine("------------------------------------------------------");
            //}

            Console.ReadLine();
        }
    }
}
