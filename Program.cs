using System;
using System.Collections.Generic;
using System.Threading;

namespace MegaProyek
{
    public class Program
    {
        static void DisplayDrink()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("              UsagiCafe              ");
            Console.WriteLine("======================================");
            Console.WriteLine("List Menu Minuman");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Kode|          Menu & Harga          ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("CP  | Cappuchino    : Rp.6000");
            Console.WriteLine("AM  | Americano     : Rp.8000");
            Console.WriteLine("ES  | Espresso      : Rp.10000");
            Console.WriteLine("VL  | Vanilla Latte : Rp.18000");
            Console.WriteLine("ML  | Matcha Latte  : Rp.20000");
            Console.WriteLine("EXT.| Keluar Dari Program");
            Console.WriteLine("======================================");
        }

        static void DisplayFood()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("              UsagiCafe              ");
            Console.WriteLine("======================================");
            Console.WriteLine("List Menu Makanan");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Kode|          Menu & Harga          ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("BA. | Bubur Ayam  : Rp.10000");
            Console.WriteLine("MG. | Mie Goreng  : Rp.8000");
            Console.WriteLine("MK. | Mie Kuah    : Rp.8000");
            Console.WriteLine("NG. | Nasi Goreng : Rp.15000");
            Console.WriteLine("KB. | Kue Balok   : Rp.3000");
            Console.WriteLine("AG  | Ayam Geprek : Rp.15000");
            Console.WriteLine("BT  | Baso Tahu   : Rp.10000");
            Console.WriteLine("MNM.| TAMPILKAN MENU MINUMAN");
            Console.WriteLine("EXT.| Keluar Dari Program");
            Console.WriteLine("======================================");
        }

        static void DisplayReceipt(Dictionary<string, int> pesanan, float diskon, float total, int ttl)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("           Rincian Pesanan          ");
            Console.WriteLine("------------------------------------");
            foreach (var item in pesanan)
            {
                Console.WriteLine(item.Key + "  " + hargaMenu[item.Key]);
                Console.WriteLine("Jumlah : " + item.Value);
                Console.WriteLine("Harga : Rp." + item.Value * hargaMenu[item.Key]);
                Console.WriteLine("");
            }
            Console.WriteLine("Total : " + ttl);
            Console.WriteLine("Diskon Belanjaan Anda : Rp." + diskon);
            Console.WriteLine("Total Bayar = Rp." + total);
            Console.WriteLine("------------------------------------");
        }

        static Dictionary<string, int> hargaMenu = new Dictionary<string, int>
        {
            { "Cappuchino", 6000 },
            { "Americano", 8000 },
            { "Espresso", 10000 },
            { "Vanilla Latte", 18000 },
            { "Matcha Latte", 20000 },
            { "Bubur Ayam", 10000 },
            { "Mie Goreng", 8000 },
            { "Mie Kuah", 8000 },
            { "Kue Balok", 3000 },
            { "Nasi Goreng", 15000 },
            { "Ayam Geprek", 15000 },
            { "Baso Tahu", 10000 }
        };

        static void ReciptCodeGenerator()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 10), N = rnd.Next(1, 10), m = rnd.Next(1, 10), M = rnd.Next(1, 10), u = rnd.Next(1, 10), U = rnd.Next(1, 10);
            string alphabet = "ABCOPASDFGHJKQWERTYUGHIJKLMNOPDEFUVWXYZZQRSTILZXCVBNM";

            int randomIndexA = rnd.Next(alphabet.Length);
            char a = alphabet[randomIndexA];

            int randomIndexB = rnd.Next(alphabet.Length);
            char b = alphabet[randomIndexB];

            int randomIndexC = rnd.Next(alphabet.Length);
            char c = alphabet[randomIndexC];

            int randomIndexD = rnd.Next(alphabet.Length);
            char d = alphabet[randomIndexD];

            Console.WriteLine($"No Struk {N}{a}{n}{b}-{M}{m}{c}-{d}{U}{u}{c}:");
        }
        static void Main(string[] args)
        {
            float diskon = 0;
            int ttl = 0;
            DateTime dt = DateTime.Now;
            Dictionary<string, int> pesanan = new Dictionary<string, int>();

            Console.WriteLine("======================================");
            Console.WriteLine("     Selamat Datang Di UsagiCafe      ");
            Console.WriteLine("======================================");
            Console.Write("Masukan Nama Anda = ");
            string nm = Console.ReadLine() ?? "";
            Console.WriteLine("");
            Console.WriteLine("Halo " + nm);
            Console.WriteLine("======================================");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.Clear();
        Start:
            while (true)
            {
                DisplayFood();
                Console.Write("Masukan Pesanan Anda : ");
                string psn = Console.ReadLine() ?? "";
                if (psn.ToLower() == "mnm")
                {
                    DisplayDrink();
                    Console.Write("Masukan Pesanan Anda : ");
                    psn = Console.ReadLine() ?? "";
                    if (psn.ToLower() == "ext")
                    {
                        Console.Write("Anda Yakin ?? (Y/N) : ");
                        string inp = Console.ReadLine() ?? "";
                        if (inp.ToLower() == "y")
                        {
                            goto END;
                        }
                        else
                        {
                            goto Start;
                        }
                    }
                }
                else if (psn.ToLower() == "ext")
                {
                    Console.Write("Anda Yakin ?? (Y/N) : ");
                    string inp = Console.ReadLine() ?? "";
                    if (inp.ToLower() == "y")
                    {
                        goto END;
                    }
                    else
                    {
                        goto Start;
                    }
                }
                Console.Write("Masukan Jumlah Pesanan : ");
                int jp = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("======================================");
                Console.WriteLine("");
                switch (psn.ToLower())
                {
                    case "cp":
                        pesanan["Cappuchino"] = jp;
                        break;
                    case "am":
                        pesanan["Americano"] = jp;
                        break;
                    case "es":
                        pesanan["Espresso"] = jp;
                        break;
                    case "vl":
                        pesanan["Vanilla Latte"] = jp;
                        break;
                    case "ml":
                        pesanan["Matcha Latte"] = jp;
                        break;
                    case "ba":
                        pesanan["Bubur Ayam"] = jp;
                        break;
                    case "mg":
                        pesanan["Mie Goreng"] = jp;
                        break;
                    case "mk":
                        pesanan["Mie Kuah"] = jp;
                        break;
                    case "kb":
                        pesanan["Kue Balok"] = jp;
                        break;
                    case "ng":
                        pesanan["Nasi Goreng"] = jp;
                        break;
                    case "ag":
                        pesanan["Ayam Geprek"] = jp;
                        break;
                    case "bt":
                        pesanan["Baso Tahu"] = jp;
                        break;
                    default:
                        {
                            Console.WriteLine("======================================");
                            Console.WriteLine("       Barang tidak terdaftar !!!");
                            Console.WriteLine("======================================");
                            Thread.Sleep(1000);
                            Console.Clear();
                            goto Start;
                        }

                }
                Console.Write("Beli Barang Lain? (Y/N): ");
                string belilagi = (Console.ReadLine() ?? "");
                if (belilagi.ToLower() == "y")
                {
                    Console.WriteLine("");
                    continue;
                }
                else if (belilagi.ToLower() == "n")
                {
                    Console.WriteLine("");
                    break;
                }
            }

            Pembayaran:
            // Menghitung total belanja
            ttl = 0;
            foreach (var item in pesanan)
            {
                ttl += item.Value * hargaMenu[item.Key];
            }
            float total = ttl;
            if (total > 400000)
            {
                diskon = total * 0.2f;
                total = total - diskon;
            }
            else if (total > 100000)
            {
                diskon = total * 0.1f;
                total = total - diskon;
            }

            DisplayReceipt(pesanan, diskon, total, ttl);
            float byr = 0;
            while (true)
            {
                Console.Write("Masukan Nominal Uang Anda = Rp.");
                if (float.TryParse(Console.ReadLine(), out byr) )
                {
                    break;
                }
                else {
                    Console.WriteLine("Invalid Input, Coba Lagi !");
                }
            }

            float kmb = byr - total;
            Console.Clear();
            void gagal()
            {
                Console.WriteLine("======================================");
                Console.WriteLine("           PEMABYARAN GAGAL          ");
                Console.WriteLine("           UANG TIDAK CUKUP     ");
                Console.WriteLine("         Kurang Rp." + (total - byr));
                Console.WriteLine("======================================");
            }

            if (byr < total)
            {
                gagal();
                while (true)
                {
                    Console.Write("apakah ingin mengulang ? Y/N = ");
                    string ulg = Console.ReadLine() ?? "";
                    switch (ulg.ToLower())
                    {
                        case "y":
                            Console.Clear();
                            goto Pembayaran;

                        case "n":
                            Console.Clear();
                            Console.WriteLine("======================================");
                            Console.WriteLine("         TRANSAKSI DIBATALKAN         ");
                            Console.WriteLine("======================================");
                            return;
                        
                        default:
                        break;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("               UsagiCafe              ");
            Console.WriteLine("        Isekai, AxelCity NO 69        ");
            Console.WriteLine("======================================");
            Console.WriteLine("Tanggal Pemesanan: " + dt.ToString("yyyy-MM-dd HH:mm"));
            ReciptCodeGenerator();
            Console.WriteLine("Pemesan : " + nm);
            Console.WriteLine("--------------------------------------");
            foreach (var item in pesanan)
            {
                Console.WriteLine(item.Key + "  " + hargaMenu[item.Key]);
                Console.WriteLine("Jumlah : " + item.Value);
                Console.WriteLine("Harga : Rp." + item.Value * hargaMenu[item.Key]);
                Console.WriteLine("");
            };
            Console.WriteLine("Total Item : " + ttl);
            Console.WriteLine("Diskon : Rp." + diskon);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Jumlah Bayar : Rp." + total);
            Console.WriteLine("Dibayar : Rp." + byr);
            Console.WriteLine("kembalian : Rp." + kmb);
            Console.WriteLine("======================================");
            Console.WriteLine("             TERIMA KASIH ");
            Console.WriteLine("======================================");
            END:
            Console.WriteLine();
        }
    }
}