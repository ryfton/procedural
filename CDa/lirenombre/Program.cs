using System;

namespace lirenombre
{
     class Program
    {
        static void Main(string[] args)
        {
            double x = 0;                      //déclaration de variable.
            double z = 0;
            Console.WriteLine("Veulliez entrer un premier nombre");
            x = (double.Parse(Console.ReadLine()));                   // lecture premier nombre.
            Console.WriteLine("Veulliez entrer un deuxieme nombre"); // lecture deuxieme nombre.
            z = (double.Parse(Console.ReadLine()));

            double res = Moyenne(x, z);

            Console.WriteLine("la moyenne est de " +res);  // appel de la méthode.

            Console.ReadKey();
            

        }
         public static double Moyenne(double _a, double _b)// méthode pour calculer la moyenne de deux nombre.
        {
            double moyenne;

            //try
            {
                   

                moyenne = (_a + _b) / 2;                                  //calcule de la moyenne.
                return moyenne;                                                     

            }
              

          //  catch(Exception )
           // {
              //  Console.WriteLine("Erreur arithmétique");

           // }
            



        }
    }
}
