using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("veuillez saisir le premier nombre pour a: ");
            a = (int.Parse(Console.ReadLine()));

            Console.WriteLine("veuillez saisir le deuxieme nombre pour b: ");
            b = (int.Parse(Console.ReadLine()));

            InversionNombre(ref a, ref b);
            Console.WriteLine("aprés inversion a devient " + a + " et b devient " + b);

            Console.ReadKey();

        }


        public static void InversionNombre(ref int _a, ref int _b)
        {
            int c;

            c = _a;
            _a = _b;
            _b = c;

        }

    }
}
