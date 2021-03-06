using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            PrinterWindows printer;
            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");
            Console.Write("Nomor Printer [1..3] : ");
            int printerNumber = Convert.ToInt32(Console.ReadLine());

            if(printerNumber == 1) {
                printer = new Epson();
            }else if(printerNumber == 2) {
                printer = new Canon();
            }else {
                printer = new LaserJet();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
