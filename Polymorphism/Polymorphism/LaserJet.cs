using System;

namespace Polymorphism
{
    internal class LaserJet : PrinterWindows
    {
        public override void Show() => Console.WriteLine("Printer Canon dimension: 12 * 12");
        public override void Print() => Console.WriteLine("Canon printer printing ...");
    }
}