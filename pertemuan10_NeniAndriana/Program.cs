using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan10_NeniAndriana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gp, tj, pot, koperasi, ttlgj;
            string nm, kd, nj;
            koperasi = 150000;  // Potongan koperasi sebesar 150,000

            Console.WriteLine("Program Gaji Karyawan");
            Console.WriteLine("---------------------\n");

            Console.Write("Nama Karyawan : ");
            nm = Console.ReadLine();
            Console.Write("Kode Jabatan  : ");
            kd = Console.ReadLine();

            if (kd == "MG")
            {
                nj = "Manager";
                gp = 4000000;
                tj = 1500000;
                pot = 500000;
            }
            else if (kd == "KB")
            {
                nj = "Kepala Bagian";
                gp = 3700000;
                tj = 1200000;
                pot = 450000;
            }
            else if (kd == "SB")
            {
                nj = "Staff Bagian";
                gp = 3500000;
                tj = 1000000;
                pot = 400000;
            }
            else if (kd == "MK")
            {
                nj = "Marketing";
                gp = 3000000;
                tj = 800000;
                pot = 350000;
            }
            else if (kd == "SL")
            {
                nj = "Sales";
                gp = 2500000;
                tj = 750000;
                pot = 300000;
            }
            else if (kd == "OB")
            {
                nj = "Office Boy";
                gp = 1500000;
                tj = 400000;
                pot = 200000;
            }
            else
            {
                nj = "Tidak Ada";
                gp = 0;
                tj = 0;
                pot = 0;
            }

            // Tampilkan rekap gaji
            Console.WriteLine($"\nHallo {nm}, Jabatan {nj}. Berikut adalah rekap gaji kamu bulan ini:");
            Console.WriteLine("Gaji Pokok    : Rp." + gp + ",00");
            Console.WriteLine("Tunjangan     : Rp." + tj + ",00");
            Console.WriteLine("Potongan      : Rp." + pot + ",00");
            Console.WriteLine("Potongan Koperasi : Rp." + koperasi + ",00");

            // Hitung gaji bersih
            ttlgj = gp + tj - pot - koperasi;

            Console.WriteLine("\nGaji Bersih yang kamu terima bulan ini sebesar: Rp." + ttlgj + ",00");

            Console.ReadKey();

        }
    }
}
