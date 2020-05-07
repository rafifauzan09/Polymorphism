﻿using System;

namespace Polymorphism
{
    class Canon : PrinterWindows
    {
        public override void Show() => Console.WriteLine("Printer Canon dimension: 9.5 * 12");
        public override void Print() => Console.WriteLine("Canon printer printing ...");
    }
}