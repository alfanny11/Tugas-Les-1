using System;

namespace TugasLesPart1_BuatInputan
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\tAlfanny Zhandra");
            Console.WriteLine("\t\t\t\t\t2006080056");
            Console.ResetColor();
            Console.WriteLine();

            // No. 1 TIPE DATA STRING INPUT NAMA LENGKAP

            // input nama secara statis

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" \n\"Input Nama Secara Statis\" ");
            int h = 8;
            int i = 9;
            int j = 10;
            int k = 11;
            int l = 12;
            int m = 13;
            int n = 14;

            Console.WriteLine("masukan variabel h = 8");
            Console.WriteLine("masukan variabel i = 9");
            Console.WriteLine("masukan variabel j = 10");
            Console.WriteLine("masukan variabel k = 11");
            Console.WriteLine("masukan variabel l = 12");
            Console.WriteLine("masukan variabel m = 13");
            Console.WriteLine("masukan variabel n = 14");
            Console.ResetColor();


            int a;
            int b;
            int c;
            int d;
            int e;
            int f;
            int g;



            // input nama secara dinamis

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" \n\"Input Nama Secara Dinamis\" ");
            Console.Write("masukan variabel a : ");
            a = int.Parse(Console.ReadLine());

            Console.Write("masukan variabel b : ");
            b = int.Parse(Console.ReadLine());

            Console.Write("masukan variabel c : ");
            c = int.Parse(Console.ReadLine());

            Console.Write("masukan variabel d : ");
            d = int.Parse(Console.ReadLine());

            Console.Write("masukan variabel e : ");
            e = int.Parse(Console.ReadLine());

            Console.Write("masukan variabel f : ");
            f = int.Parse(Console.ReadLine());

            Console.Write("masukan variabel g : ");
            g = int.Parse(Console.ReadLine());
            Console.ResetColor();


            // No. 2 DATA INTEGER PENJUMLAHAN, PENGURANGAN, DAN PERKALIAN SECARA STATIS

            // Penjumlahan
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" \n\"Penjumlahan\" ");
            Console.WriteLine(a + b);
            Console.WriteLine(c + d + e);
            Console.WriteLine(f + g);
            Console.ResetColor();
            
            
            // Pengurangan
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" \n\"Pengurangan\" ");
            Console.WriteLine(a - b);
            Console.WriteLine(c - d - e);   
            Console.WriteLine(f - g);
            Console.ResetColor();

            // Perkalian
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" \n\"Perkalian\" ");
            Console.WriteLine(a * b);
            Console.WriteLine(c * d * e);
            Console.WriteLine(f * g);
            Console.ResetColor();

            Console.ReadLine();




                
          
        

            


        }
    }
}
