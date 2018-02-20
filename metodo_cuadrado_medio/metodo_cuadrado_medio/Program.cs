using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_cuadrado_medio
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodoCuadradoMedio mcm = new MetodoCuadradoMedio();
            int n, iteraciones;
            string semilla, semillaAlCuadrado, semillaNueva, random;

            Console.WriteLine("Ingresar n");
            n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Ingresar semilla");
            semilla = Console.ReadLine();

            if(semilla.Length != (2 * n))
            {
                Console.WriteLine("Semilla incorrecta");
                Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Ingresar el num de iteraciones");
            iteraciones = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();
            Console.Write("i\tZi\tZi2\t\tZnueva\tR\t\n");

            for(int i = 1; i <= iteraciones; i++)
            {
                semillaAlCuadrado = mcm.semillaAlCuadrado(semilla, n);
                semillaNueva = mcm.semillaNueva(semillaAlCuadrado, n);
                random = mcm.random(semillaNueva);
                Console.Write(i + "\t" + semilla + "\t" + semillaAlCuadrado + "\t" + semillaNueva + "\t" + random + "\t");
                Console.WriteLine();
                semilla = semillaNueva;
            }

            Console.ReadKey();
        }
    }

    class MetodoCuadradoMedio
    {
        int semilla;
        string semilla_string;
        string semilla_nueva;
               
        public string semillaAlCuadrado(string semilla, int n)
        {
            this.semilla = Convert.ToInt32(semilla);
            this.semilla = Convert.ToInt32(Math.Pow(this.semilla, 2));
            semilla_string = Convert.ToString(this.semilla);
            
            if(semilla_string.Length == (4 * n))
            {
                return semilla_string;
            }   else
            {
                for (int i = semilla_string.Length; i < (4* n); i++)
                {
                    semilla_string = "0" + semilla_string;
                }
                return semilla_string;
            }         
        }

        public string semillaNueva(string semilla_string, int n)
        {
            semilla_nueva = "";
            for (int i = 0; i < (4 * n); i++)
            {
                if (i >= n && i < (4 * n - n))
                    semilla_nueva = semilla_nueva + semilla_string.Substring(i, 1);
            }

            return semilla_nueva;
        }

        public string random(string semilla_string)
        {
            return "0." + semilla_string;
        }
    }
}
