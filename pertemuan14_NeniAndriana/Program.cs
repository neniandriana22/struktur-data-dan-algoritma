using System;
using System.Collections;

namespace Pertemuan14_NeniAndriana
{
    internal class Program
    {
        // Data Khusus untuk transaksi
        static ArrayList idBuku = new ArrayList();
        static ArrayList judulBuku = new ArrayList();
        static ArrayList namaPeminjam = new ArrayList();
        static ArrayList tglPeminjaman = new ArrayList();
        static ArrayList tglPengembalian = new ArrayList();

        // Data Umum
        static ArrayList kategoriBuku = new ArrayList();
        static ArrayList penerbitBuku = new ArrayList();

        static void header()
        {
            Console.WriteLine("Program Perpustakaan");
            Console.WriteLine("=====================");
        }

        static void tambahData()
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
                Console.Write("Masukkan ID Buku: ");
                idBuku.Add(Console.ReadLine());
                Console.Write("Masukkan Judul Buku: ");
                judulBuku.Add(Console.ReadLine());
                Console.Write("Masukkan Nama Peminjam: ");
                namaPeminjam.Add(Console.ReadLine());
                Console.Write("Masukkan Tanggal Peminjaman: ");
                tglPeminjaman.Add(Console.ReadLine());
                Console.Write("Masukkan Tanggal Pengembalian: ");
                tglPengembalian.Add(Console.ReadLine());

                // Data Umum (Tidak selalu terlibat dalam transaksi)
                Console.Write("Masukkan Kategori Buku: ");
                kategoriBuku.Add(Console.ReadLine());
                Console.Write("Masukkan Nama Penerbit Buku: ");
                penerbitBuku.Add(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Data Berhasil Ditambahkan");
            Console.WriteLine("==========================================");
        }

        static void tampilkanSemuaData()
        {
            if (idBuku.Count == 0)
            {
                Console.WriteLine("Belum Ada Data Yang Dimasukkan");
                return;
            }

            for (int i = 0; i < idBuku.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("====================================");
                Console.WriteLine("DATA TRANSAKSI PERPUSTAKAAN KE " + (i + 1));
                Console.WriteLine("====================================");
                Console.WriteLine("ID Buku: " + idBuku[i]);
                Console.WriteLine("Judul Buku: " + judulBuku[i]);
                Console.WriteLine("Nama Peminjam: " + namaPeminjam[i]);
                Console.WriteLine("Tanggal Peminjaman: " + tglPeminjaman[i]);
                Console.WriteLine("Tanggal Pengembalian: " + tglPengembalian[i]);
                Console.WriteLine("Kategori Buku: " + kategoriBuku[i]);
                Console.WriteLine("Penerbit Buku: " + penerbitBuku[i]);
            }
        }

        static void Main(string[] args)
        {
            int pilihan = 0;

            while (true)
            {
            Atas:
                header();
                Console.WriteLine("1. Tambah Data Transaksi");
                Console.WriteLine("2. Tampilkan Semua Data Transaksi");
                Console.WriteLine("3. Bersihkan Layar");
                Console.WriteLine("4. Keluar");
                Console.Write("Masukkan pilihan Anda: ");
                pilihan = int.Parse(Console.ReadLine());

                if (pilihan == 1)
                {
                    tambahData();
                }
                else if (pilihan == 2)
                {
                    tampilkanSemuaData();
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