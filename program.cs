using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2621
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan("Chroizen","192213" , 5000000);
            Karyawan karyawan2 = new Karyawan("Zeronice","192512", 6000000);
            Karyawan karyawan3 = new Karyawan("Darkness", "192612", 7500000);



            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.lihatKaryawan();
            Console.WriteLine();
            karyawan2.lihatKaryawan();
            Console.WriteLine();
            karyawan3.lihatKaryawan();



            Console.WriteLine("\n\n Njeer kenaikan gaji MANTAP");



            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.NaikGaji();
            Console.WriteLine();
            karyawan2.NaikGaji();
            Console.WriteLine();
            karyawan3.NaikGaji();



            Console.ReadKey();
        }
    }
}