using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valeurAbsolue
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombrRéel = 0;


            Console.WriteLine("Ce programme permet de determiner la valeur absolue d'un nombre réel, veuillez saisir un nombre : ");
            nombrRéel=(int.Parse(Console.ReadLine()));
            if (nombrRéel>0)

            {
                Console.WriteLine(nombrRéel);


            }
            else
            {
                Console.WriteLine(nombrRéel);
            }
            Console.ReadKey();

        }
    }
}
