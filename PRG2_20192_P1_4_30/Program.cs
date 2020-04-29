using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20192_P1_4_30
{
    class Program
    {
        public static double alas, tinggi = 0;

        static void Main(string[] args)
        {
            /* DEKLARASI */
            int pilih;


            /* ALGORITMA */
            do
            {

                Console.Clear();
                Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
                Console.Write("a. Hitung Luas\nb. Hitung Hipotenusa\nc. Hitung Keliling\nd. Keluar\n");
                Console.Write("Menu pilihan\t: ");

                pilih = Convert.ToInt16(Console.ReadLine());
                switch (pilih)
                {
                    case 1:
                        Luas(); break;
                    case 2:
                        Hipotenusa(); break;
                    case 3:
                        Keliling(); break;
                    case 4:
                        Console.WriteLine("TERIMA KASIH");break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Pilih dengan benar!"); Console.ReadLine(); break;
                }
                
            } while (pilih != 4);
        }

        public static void Luas()
        {
            /* DEKLARASI */
            


            /* ALGORITMA */
            Console.Clear();
            Console.WriteLine("LUAS SEGITIGA\n");
            Console.Write("Masukkan alas\t: "); alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan alas\t: "); tinggi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nLuas segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan \n\n", alas, tinggi, ((alas * tinggi)/2.0));
            Console.ReadLine();
        }

        public static void Hipotenusa()
        {
            /* DEKLARASI */


            /* ALGORITMA */
            Console.Clear();
            Console.WriteLine("HIPOTENUSA\n");
            Console.Write("Masukkan alas\t: "); alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan alas\t: "); tinggi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nHipotenusa segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan \n\n", alas, tinggi, (Math.Sqrt((alas*alas)+(tinggi*tinggi))));
            Console.ReadLine();
        }

        public static void Keliling()
        {
            /* DEKLARASI */


            /* ALGORITMA */
            Console.Clear();
            Console.WriteLine("Keliling\n");
            Console.Write("Masukkan alas\t: "); alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan alas\t: "); tinggi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nKeliling segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan \n\n", alas, tinggi, (alas+tinggi+Math.Sqrt((alas * alas) + (tinggi * tinggi))));
            Console.ReadLine();
        }
    }
}
