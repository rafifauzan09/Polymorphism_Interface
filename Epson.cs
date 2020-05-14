using System;

namespace PolymorphismInterface
{
    class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Epson dimension: 10 * 11");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing ...");
        }
    }
}