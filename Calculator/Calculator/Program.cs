using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("***********************");
            Console.WriteLine("Pilih menu calculator");
            Console.WriteLine("***********************");

            Console.WriteLine();

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine();

            Console.Write("Input nomor menu [1-4] : ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (pilihan < 1 || pilihan > 4)
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
            }
            else
            {
                Console.Write("Inputkan nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (pilihan == 1)
                {
                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                }
                else if (pilihan == 2)
                {
                    Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
                }
                else if (pilihan == 3)
                {
                    Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
                }
                else if (pilihan == 4)
                {
                    Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + Pembagian(a, b));
                }
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}