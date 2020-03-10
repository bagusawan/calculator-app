using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Apliaksi Calculator";
            
            Console.WriteLine("1. penambahan \n2. pengurangan \n3. perkalian \n4. pembagian");
            Console.Write("pilihan operasi : ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            Console.Write("input nilai a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("input nilai b : ");
            int b = int.Parse(Console.ReadLine());

            switch (pilihan) {
                case 1:
                    Console.WriteLine("Hasil Penambahan" + a + " + " + b + " = " + Penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pegurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                    break;
                default:
                    break;
                    
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
