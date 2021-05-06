using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValeursAcquise
{
    class Program
    {
        static void Main(string[] args)
        {
            double somme, intérêt, nombrAnnées;

            Console.WriteLine("veuillez saisir le montant initiale: ");
            somme=(double.Parse(Console.ReadLine()));

            Console.WriteLine("veuillez saisir le taux d'intérêt: ");
            intérêt = (double.Parse(Console.ReadLine()));

            Console.WriteLine("veuillez saisir le nombre d'années: ");
            nombrAnnées = (double.Parse(Console.ReadLine()));

            Console.WriteLine("la valeur acquise par la somme "+somme+" euros pendant la durée de "+nombrAnnées+" ans avec un intérêt simple de "+intérêt+" est de " + (Math.Round(IntérêtSimple(somme, intérêt, nombrAnnées), 2)));
            
            Console.WriteLine("Et la valeur acquise par la somme " + somme + " euros pendant la durée de " + nombrAnnées + " ans avec un intérêt composé de " + intérêt + " est de " + (Math.Round(IntérêtComposé(somme, intérêt, nombrAnnées), 2)));

            Console.ReadKey();

        }
        public static double IntérêtSimple(double _sommeIn, double _intérêt, double _nombreAnnées)
        {

            double intérêtSimple =_sommeIn*(1 + (_nombreAnnées *( _intérêt/100)));
            return intérêtSimple;
        }
        public static double IntérêtComposé(double _sommeIn, double _intérêt, double _nombreAnnées)
        {

            double intérêtComposé = _sommeIn * Math.Pow(1 + (_intérêt/100),_nombreAnnées);
            return intérêtComposé;
        }

    }
}
