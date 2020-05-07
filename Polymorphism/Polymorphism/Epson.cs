using System;

namespace Polymorphism
{
    internal class Epson : PrinterWindows
    {
        public override void Show() => Console.WriteLine("Printer Canon dimension: 10 * 11");
        public override void Print() => Console.WriteLine("Canon printer printing ...");
    }
}