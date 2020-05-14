using NHibernate.Impl;
using System;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafif Fauzan Almahdy | 19.11.2750 \n");


            IPrinterWindows printer = new PrinterWindows();
            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet \n");

            Console.Write("Nomor Printer [1...3]:");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            if (nomorPrinter == 2)
                printer = new Canon();
            else if (nomorPrinter == 3)
                printer = new LaserJet();
            else
                Console.WriteLine("Error : Pilihan Tidak Ada");

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
