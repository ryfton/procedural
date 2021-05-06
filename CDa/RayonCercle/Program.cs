using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayonCercle
{
     public class Program
    {
        public static void Main(string[] args)
        {
            double rayonc = 0;
            double angl = 0;
            Console.WriteLine("veuilliez saisir le rayon du cercle.");
            rayonc = (double.Parse(Console.ReadLine()));
            Console.WriteLine("veuilliez saisir l'angle du cercle.");
            angl = (double.Parse(Console.ReadLine()));
            Console.WriteLine("l'aire du secteur circulaire est de: " +(Math.Round(AireCirculaire(rayonc,angl),2)));
            
            Console.ReadKey();
        }
        public static double AireCirculaire(double _ray, double _ang)
        {
            double aireCirc = Math.PI * Math.Pow(_ray, 2) * (_ang / 360);
            return aireCirc;
        }
           
    
     
    }
   
}
