using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace résoudreEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;

            Console.WriteLine("Ce programme permet de resoudre l'équation  a * x + b = 0.\n");

            Console.WriteLine("veuillez saisire le nombre pour la valeur a:");
            a = (int.Parse(Console.ReadLine()));

            Console.WriteLine("veuillez saisire le nombre pour la valeur b:");
            b = (int.Parse(Console.ReadLine()));

            float resultat = CalculEquation(a, b);
            Console.WriteLine("x est donc egale à: "+resultat);
            Console.ReadKey();

        }
        public static float CalculEquation(float _a,float _b)
        {
            float calcule;
            if (_a==0 && _b !=0)
            {
                throw new Exception("Equation impossible ");

            }
            if (_a==0 && _b==0)
            {
                throw new Exception("Equation indeterminée.");
            }
            calcule = -_b / _a;
            return calcule;
        }
    }
}
