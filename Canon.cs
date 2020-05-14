﻿using System;

namespace PolymorphismInterface
{
    class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Canon dimension: 9.5 * 12");
        }

        public void Print()
        {
            Console.WriteLine("Canon printer printing ...");
        }
    }
}