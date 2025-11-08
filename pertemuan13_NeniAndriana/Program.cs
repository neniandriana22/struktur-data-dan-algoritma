using System;
using System.Collections;

namespace pertemuan13_NeniAndriana
{
    internal class Program
    {
        static ArrayList nama = new ArrayList();
        static ArrayList no_hp = new ArrayList();
        static ArrayList tujuan = new ArrayList();
        static ArrayList harga = new ArrayList();

        static void header()
        {
            Console.WriteLine("Program ArrayList Tiket");
            Console.WriteLine("========================");
        }

        static void tambahdata()
        {
            int jumlah;
            Console.WriteLine();
            Console.Write("Masukkan jumlah data yang ingin ditambahkan: ");
            jumlah = int.Parse(Console.ReadLine());

            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(" DATA KE " + (i + 1));
                Console.WriteLine("------------------");
                Console.Write("Masukkan Data Nama: ");
                nama.Add(Console.ReadLine());
                Console.Write("Masukkan Data No HP: ");
                no_hp.Add(Console.ReadLine());
                Console.Write("Masukkan Data Tujuan Keberangkatan: ");
                tujuan.Add(Console.ReadLine());
                Console.Write("Masukkan Data Harga: ");
                harga.Add(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Data Berhasil Ditambahkan");
            Console.WriteLine("==========================================");
            Console.WriteLine();
        }

        static void Tampilsemua()
        {
            if (nama.Count == 0)
            {
                Console.WriteLine("Belum Ada Data Yang Dimasukkan");
                return;
            }

            for (int i = 0; i < nama.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("===================================");
                Console.WriteLine("DATA PENUMPANG KE " + (i + 1));
                Console.WriteLine("===================================");
                Console.WriteLine("Nama: " + nama[i]);
                Console.WriteLine("No HP: " + no_hp[i]);
                Console.WriteLine("Tujuan: " + tujuan[i]);
                Console.WriteLine("Harga: " + harga[i]);
            }
        }

        static void Main(string[] args)
        {
            int pilihan = 0;

            while (true)
            {
            Atas:
                header();
                Console.WriteLine("1. Tambah Data");
                Console.WriteLine("2. Tampilkan Semua Data");
                Console.WriteLine("3. Bersihkan Layar");
                Console.WriteLine("4. Keluar");
                Console.Write("Masukkan pilihan Anda: ");
                pilihan = int.Parse(Console.ReadLine());

                if (pilihan == 1)
                {
                    tambahdata();
                }
                else if (pilihan == 2)
                {
                    Tampilsemua();
                }
                else if (pilihan == 3)
                {
                    Console.Clear();
                    goto Atas;
                }
                else if (pilihan == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid.");
                }
            }
        }
    }
}