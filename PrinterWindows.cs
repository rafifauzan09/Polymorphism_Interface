using System;

namespace PolymorphismInterface
{
    class PrinterWindows : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Windows display dimension: ");
        }

        public void Print()
        {
            Console.WriteLine("Printer Windows printing... ");
        }
    }
}