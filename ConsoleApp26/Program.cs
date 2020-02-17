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

            var kategori = vt.Kategoriler.Where(i => i.Id == 1).FirstOrDefault();

            if(kategori != null)
            {
                vt.Kategoriler.Remove(kategori);
            }
            vt.SaveChanges();


            Console.ReadLine();
        }
    }
}
