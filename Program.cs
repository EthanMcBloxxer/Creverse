using System;
using System.Windows.Forms;

namespace Creverse
{
    class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Console.WriteLine("Creverse (Console Reverse) by EthanMcBloxxer under the Unlicense");
            Console.WriteLine();
            while (true)
            {
                Console.Write("Creverse>");
                string x = Console.ReadLine();
                char[] xa = x.ToCharArray();
                Array.Reverse(xa);
                string y = "";
                foreach (char tmp in xa) {y += tmp;}
                try
                {
                    Clipboard.SetText(y);
                    Console.WriteLine(y + " (copied)");
                }
                catch
                {
                    Console.WriteLine(y);
                }
                Console.WriteLine();
            }
        }
    }
}