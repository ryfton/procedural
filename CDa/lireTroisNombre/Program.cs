using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lireTroisNombre
{
    class Program
    {
        static void Main(string[] args)
        { 
            // declaration
            int[] t = new int[3];
            int min=0, max=0, som=0, c=0;
            bool flag = true; 
            // remplissage
            Console.WriteLine("Ce programme permet de trier des entiers,veuillez saisir 3 entiers: ");
            for (int i = 0; i < 3; i++)
            {
                t[i] = Convert.ToInt16(Console.ReadLine());
                if (i==0)
                {
                    min = t[i]; max = t[i]; som = t[i];
                }
                else
                {
                    if (t[i] < min) min = t[i];
                    if (t[i] > max) max = t[i];
                    som += t[i];
                }
            }
            //traitement de tri
            do
            {
                flag = true;
                for (int i = 0; i < 3; i++)
                    if (t[i] > t[i + 1])
                    {
                        c = t[i];
                        t[i] = t[i + 1];
                        t[i + 1] = c;
                        flag = false;
                    }
            } while (!flag);
            //affichage
            for (int i = 0; i < 3; i++)
            {
                Console.Write(t[i] + "- \t");
            }
            Console.WriteLine();
            Console.WriteLine("la valeur maximale est " + max);
            Console.WriteLine("la valeur minimale est " + min);
            Console.WriteLine("la valeur moyenne est " + som/3);
            Console.WriteLine("tapez une touche pour quitter");
            Console.ReadKey();
        }
        //public static bool TriNombre(Flag )
    }
}
