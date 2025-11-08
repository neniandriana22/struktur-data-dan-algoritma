using System;

namespace pertemuan12_NeniAndriana
{
    internal class Program
    {
        static void persegipanjang()
        {
            int p, l, L;
            Console.Write("MENCARI LUAS PERSEGI PANJANG");
            Console.WriteLine();
            Console.Write("masukkan nilai panjang : "); p = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai lebar : "); l = int.Parse(Console.ReadLine());

            L = p * l;

            Console.WriteLine();
            Console.Write("Luas Persegi Panjang Adalah " + L + " cm ");
        }

        static void segitiga()
        {
            int a, t, Ls;
            Console.Write("MENCARI LUAS SEGITIGA");
            Console.WriteLine();
            Console.Write("masukkan nilai alas : "); a = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai tinggi : "); t = int.Parse(Console.ReadLine());

            Ls = (a * t) / 2;

            Console.WriteLine();
            Console.Write("Luas Segitiga Adalah " + Ls + " cm ");
        }

        static void balok()
        {
            int p, l, t, V;
            Console.Write("MENCARI VOLUME BALOK");
            Console.WriteLine();
            Console.Write("masukkan nilai panjang : "); p = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai lebar : "); l = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai tinggi : "); t = int.Parse(Console.ReadLine());

            V = p * l * t;

            Console.WriteLine();
            Console.Write("Volume Balok Adalah " + V + " cm³ ");
        }

        static void lingkaran()
        {
            double r, L;
            const double pi = 3.14159; 
            Console.Write("MENCARI LUAS LINGKARAN");
            Console.WriteLine();
            Console.Write("masukkan nilai jari-jari : "); r = double.Parse(Console.ReadLine());

            L = pi * r * r;

            Console.WriteLine();
            Console.Write("Luas Lingkaran Adalah " + L + " cm² ");
        }

        static void kubus()
        {
            int s, V;
            Console.Write("MENCARI VOLUME KUBUS");
            Console.WriteLine();
            Console.Write("masukkan panjang sisi : "); s = int.Parse(Console.ReadLine());

            V = s * s * s;

            Console.WriteLine();
            Console.Write("Volume Kubus Adalah " + V + " cm³ ");
        }

        static void trapesium()
        {
            int a, b, t, L;
            Console.Write("MENCARI LUAS TRAPESIUM");
            Console.WriteLine();
            Console.Write("masukkan nilai alas pertama : "); a = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai alas kedua : "); b = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai tinggi : "); t = int.Parse(Console.ReadLine());

            L = ((a + b) / 2) * t;

            Console.WriteLine();
            Console.Write("Luas Trapesium Adalah " + L + " cm² ");
        }

        static void Main(string[] args)
        {
            int pilihan;
            string pilih;

        atas:
            Console.Write("[1]. Luas Persegi Panjang \n[2]. Luas Segitiga\n[3]. Volume Balok\n[4]. Luas Lingkaran\n[5]. Volume Kubus\n[6]. Luas Trapesium\n" +
                          "[7]. Bersihkan Layar\n\nMasukkan pilihan anda: ");
            pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (pilihan == 1)
            {
                persegipanjang();
            }
            else if (pilihan == 2)
            {
                segitiga();
            }
            else if (pilihan == 3)
            {
                balok();
            }
            else if (pilihan == 4)
            {
                lingkaran();
            }
            else if (pilihan == 5)
            {
                kubus();
            }
            else if (pilihan == 6)
            {
                trapesium();
            }
            else if (pilihan == 7)
            {
                Console.Clear();
                goto atas;
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("APAKAH INGIN LANJUT MENCARI LUAS BANGUN YANG LAIN\nMasukkan pilihan anda Y/T: ");
            pilih = Console.ReadLine();
            if (pilih == "Y")
            {
                goto atas;
            }
            else if (pilih == "T")
            {
                Console.Clear();
                goto atas;
            }
            else
            {
                Console.Write("Pilihan tidak valid.");
            }
        }
    }
}