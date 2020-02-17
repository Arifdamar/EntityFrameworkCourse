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

            //var urun = vt.Urunler.Where(i => i.Id == 1).FirstOrDefault();
            //var urunler = vt.Urunler.Where(i => i.KategoriId == 1).ToList();

            //var urunler = vt.Kategoriler.Where(i => i.KategoriAdi == "Telefon")
            //   .SelectMany(i => i.Urunler).ToList();

            var kategoriler = vt.Kategoriler
                .Where(i => i.KategoriAdi == "Bilgisayar" || i.Id == 1)
                .Select(i => new KategoriUrunModel()
                {
                    KategoriAdi = i.KategoriAdi,
                    Urunler = i.Urunler.Where(k => k.StokAdet > 300).Select(j => new UrunModel
                    {
                        UrunAdi = j.UrunAdi,
                        Fiyat = j.Fiyat
                    }).ToList()
                }).ToList();


            foreach (var kategori in kategoriler)
            {
                Console.WriteLine("Ürün Kategori: {0}", kategori.KategoriAdi);
                foreach (var urun in kategori.Urunler)
                {
                    Console.WriteLine("Ürün Adı: {0}\nÜrün Fiyatı: {1}", urun.UrunAdi, urun.Fiyat);
                }
                Console.WriteLine("------------------------");
            }

            Console.ReadLine();
        }
    }
}
