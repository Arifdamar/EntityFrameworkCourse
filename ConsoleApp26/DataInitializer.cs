using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class DataInitializer : DropCreateDatabaseIfModelChanges<VTContext>
    {
        protected override void Seed(VTContext context)
        {

            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){ KategoriAdi = "Telefon" },
                new Kategori(){ KategoriAdi = "Bilgisayar" },
                new Kategori(){ KategoriAdi = "Laptop" },
                new Kategori(){ KategoriAdi = "Beyaz Eşya" }
            };

            foreach (var kategori in kategoriler)
            {
                context.Kategoriler.Add(kategori);
            }

            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){ UrunAdi = "Samsung S4", Fiyat = 1000, StokAdet = 125, KategoriId=1 },
                new Urun(){ UrunAdi = "Samsung S5", Fiyat = 2000, StokAdet = 250, KategoriId=1 },
                new Urun(){ UrunAdi = "Samsung S6", Fiyat = 3000, StokAdet = 300, KategoriId=1},
                new Urun(){ UrunAdi = "Samsung S7", Fiyat = 4000, StokAdet = 500, KategoriId=1 },
                new Urun(){ UrunAdi = "Samsung S8", Fiyat = 5000, StokAdet = 850, KategoriId=1 },
                new Urun(){ UrunAdi = "Monster Abra A5", Fiyat = 3000, StokAdet = 125, KategoriId=2 },
                new Urun(){ UrunAdi = "Monster Abra A7", Fiyat = 7000, StokAdet = 250, KategoriId=2 },
                new Urun(){ UrunAdi = "Monster Abra A9", Fiyat = 11000, StokAdet = 300, KategoriId=2},
                new Urun(){ UrunAdi = "Monster Abra A5 v12", Fiyat = 4000, StokAdet = 500, KategoriId=2 },
                new Urun(){ UrunAdi = "Monster Abra A5 v12.1", Fiyat = 4500, StokAdet = 850, KategoriId=2 }
            };

            foreach (var urun in urunler)
            {
                context.Urunler.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
