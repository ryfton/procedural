using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double rayon = 0;
            double aire = 0;
            double volume = 0;

            Console.WriteLine("entrer le rayon de la sphére a calculer");
            rayon = (double.Parse(Console.ReadLine()));

            Console.WriteLine("l'aire de la sphére est de: "+(Math.Round(Aire(rayon),2) + " et le volume de: "+(Math.Round(Volume(rayon),2))));


            Console.ReadKey();



        }
        public static double Aire( double _a)
        {
           double aire = 4 * (Math.PI) * Math.Pow(_a, 2);
            return aire;

        }
        public static double Volume(double _v)
        {
            double volume = 4d / 3 * (Math.PI) * Math.Pow(_v, 3);
            return volume;
        }



    }
}
