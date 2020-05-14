﻿using System;

namespace PolymorphismInterface
{
    class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer LaserJet dimension: 12 * 12");
        }

        public void Print()
        {
            Console.WriteLine("LaserJet printer printing ...");
        }
    }
}