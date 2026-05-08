using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;

            Console.WriteLine("insira o valor da base");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("insira o valor de altura");
                h = int.Parse(Console.ReadLine());

            Console.WriteLine("o valor da área é");
            a = b * h;
            Console.WriteLine(a);

               

        }
    }
}
