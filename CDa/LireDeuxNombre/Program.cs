using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LireDeuxNombre
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("veuilliez entrer un premier nombre");
            a= (int.Parse(Console.ReadLine()));

            Console.WriteLine("veuilliez entrer un deuxieme nombre");
            b = (int.Parse(Console.ReadLine()));

            Console.WriteLine(OrdreCroissant( a ,  b));

        }
        public  static string OrdreCroissant(int _a,int _b)
        {
           string ordre="";
            
                if (_a < _b)
                {
                    ordre= "l'ordre croissant est: " + _a + " suivi de " + _b;
                    Console.WriteLine(ordre);  
                }
                if (_b < _a)
                {
                    ordre = "l'ordre croissant est: " + _a + " suivi de " + _b;
                    Console.WriteLine(ordre);
                }
            return ordre;
           
        }

    }
}
