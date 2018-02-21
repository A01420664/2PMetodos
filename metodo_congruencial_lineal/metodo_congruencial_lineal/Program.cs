using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_congruencial_lineal
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, a, c, z, zi, n;

            Console.WriteLine("Ingresa m");
            m = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingresa a");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingresa c");
            c = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingresa z");
            z = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingresa el num de iteracions");
            n = Convert.ToInt16(Console.ReadLine());

            Console.Write("i\tm\tc\tz\ta\tZi+1\t\n");
            for(int i = 1; i <= n; i++)
            {
                zi = ((a * z) + c) % m;
                Console.Write(i + "\t" + m + "\t" + c + "\t" + z + "\t" + a + "\t" + zi + "\n");
                z = zi;
            }
            Console.ReadKey();
        }

        
    }
}
