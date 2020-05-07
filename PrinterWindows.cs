using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class PrinterWindows
    {
        public string Name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("\nPrinter display dimension");
        }

        public virtual void Print()
        {
            Console.WriteLine("\nPrinter printing");
        }
    }
}
