using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Z9_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("C:/Users/Алина/Desktop/text.txt");
            int n = 1;
            while (n < lines.Length)
            {
                Console.WriteLine(lines[n]);
                n += 2;
            }
            Console.ReadKey();
        }
    }
}
