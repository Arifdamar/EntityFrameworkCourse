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
            Kategori k = new Kategori();
            k.KategoriAdi = "Telefon";

            VTContext vt = new VTContext();
            vt.Kategoriler.Add(k);
            vt.SaveChanges();

            Console.WriteLine("Veri kayıt edildi");
            Console.ReadLine();


        }
    }
}
