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
         
            // remplissage
            Console.WriteLine("Ce programme permet de trier des entiers,veuillez saisir 3 entiers: ");
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = Convert.ToInt16(Console.ReadLine());
            }           
            //traitement de tri
            TriBule(t);
            //affichage
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i] + "- \t");
            }
            Console.WriteLine();
           
            Console.WriteLine("tapez une touche pour quitter");
            Console.ReadKey();
        }
        public static void TriBule(int[] _t)
        {
            bool flag = true;
            int c = 0;
            do
            {
                flag = true;
                for (int i = 0; i < (_t.Length - 1); i++)

                    if (_t[i] > _t[i + 1])
                    {
                        c = _t[i];
                        _t[i] = _t[i + 1];
                        _t[i + 1] = c;
                        flag = false;
                    }
            } while (!flag);

        }



    }
}










