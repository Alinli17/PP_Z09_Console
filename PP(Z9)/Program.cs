using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Z9_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер последовательности: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Заданнное число: ");
            int k = Int32.Parse(Console.ReadLine());
            double[] arr = new double[n];
            FileStream f = new FileStream("C:/Users/Алина/Desktop/t.dat", FileMode.Open);
            BinaryWriter fOut = new BinaryWriter(f);
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = double.Parse(Console.ReadLine());
                fOut.Write(arr[i]);
            }
            fOut.Close();
            Console.WriteLine("\n"+"Результат: ");
            f = new FileStream("C:/Users/Алина/Desktop/t.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long m = f.Length;
            for (long i = 8; i < m; i += 16)
            { 
                f.Seek(i, SeekOrigin.Begin);
                arr[0] = fIn.ReadDouble();
                if (arr[0] > k)
                {
                    Console.WriteLine("{0:f2}", arr[0]);
                }
            }
            fIn.Close();
            f.Close();
            Console.ReadKey();
        }
    }
}
