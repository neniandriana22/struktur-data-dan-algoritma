using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan11_NeniAndriana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nm, kd, nt, nh, mbl, np;
            int ht, jp, htb, ub, uk;

            Console.WriteLine("----PROGRAM TIKET----");
            Console.WriteLine("---------------------");
            Console.Write(" NAMA PENUMPANG   : "); nm = Console.ReadLine();
            Console.Write(" No Handphone     : "); nh = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("-- DAFTAR KODE TUJUAN --");
            Console.WriteLine(" [1]. PADANG     = PD \n [2]. PALEMBANG  = PL \n [3]. PEKANBARU  = PK \n [4]. MEDAN      = MDN \n [5]. LAMPUNG    = LP \n [6]. BENGKULU   = BKL \n ");
            Console.WriteLine();

            Console.Write(" KODE TUJUAN    : "); kd = Console.ReadLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            if (kd == "PD")
            {
                nt = "PADANG";
                ht = 200000;
                mbl = "Toyota Avanza";
                np = "B 1234 XYZ";
            }
            else if (kd == "PL")
            {
                nt = "PALEMBANG";
                ht = 150000;
                mbl = "Honda Civic";
                np = "D 5678 ABC";
            }
            else if (kd == "PK")
            {
                nt = "PEKANBARU";
                ht = 250000;
                mbl = "BMW X5";
                np = "B 9012 DEF";
            }
            else if (kd == "MDN")
            {
                nt = "MEDAN";
                ht = 300000;
                mbl = "Suzuki Swift";
                np = "L 3456 GHI";
            }
            else if (kd == "LP")
            {
                nt = "LAMPUNG";
                ht = 350000;
                mbl = "Mercedes-Benz C-Class";
                np = "F 7890 JKL";
            }
            else if (kd == "BKL")
            {
                nt = "BENGKULU";
                ht = 400000;
                mbl = "issan Serena";
                np = "B 2468 MNO";
            }
            else
            {
                nt = "TIDAK ADA";
                ht = 0;
                mbl = "TIDAK ADA";
                np = "TIDAK ADA";
            }

            Console.WriteLine(" Tujuan Anda Adalah       : " + nt);
            Console.WriteLine(" Harga Tiket Anda Adalah  : " + ht);
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.Write(" SILAHKAN MASUKKAN JUMLAH PENUMPANG : "); jp = int.Parse(Console.ReadLine());
            Console.WriteLine();

            htb = jp * ht;

            Console.WriteLine(" Jumlah Penumpang Anda Adalah : " + jp + " Orang");
            Console.WriteLine(" TOTAL PEMBAYARAN ANDA ADALAH Rp. " + htb + " Rupiah");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.Write(" JUMLAH UANG YANG DIBAYARKAN : "); ub = int.Parse(Console.ReadLine());

            uk = ub - htb;

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("---------------DATA KEBERANGKATAN PENUMPANG----------------------");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine(" Halo " + nm + "   ||   " + " No. HP " + nh);
            Console.WriteLine(" Tujuan Keberangkatan Anda Adalah " + nt + " Dengan Jumlah Penumpang " + jp + " Orang ");
            Console.WriteLine(" Kendaraan yang akan digunakan adalah " + mbl + " Dengan Nopol " + np);
            Console.WriteLine(" TOTAL PEMBAYARAN TIKET SEBESAR Rp. " + htb);
            Console.WriteLine(" UANG KEMBALIAN ANDA ADALAH  Rp. " + uk + " ");
            Console.WriteLine(" TERIMA KASIH, SEMOGA PERJALANANMU MENYENANGKAN ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

        }
    }
}