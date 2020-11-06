using System;

namespace tt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir les distances avec l'unité à convertir et les separer par un espace ( unité km ou mi)");
            
            string Distances= Console.ReadLine().ToLower();
            string[] tabdist = Distances.Split(" ");
            double Distance;
            for (int i = 0; i < tabdist.Length; i++)
            {

                string sschaine = tabdist[i].Substring(tabdist.Length - 2, 2);
                Distance = double.Parse((tabdist[i].Substring(0, (tabdist.Length - 2))));
                Console.Write(tabdist[i] + "\t");

                bool testnombre = false;
                if (true)
                {

                }

            }
            //bool testnombre = false;
            //testnombre = double.TryParse(Dist, out Distance);
            //double n = 0;
            //double[] entremi = new double[n]{ };// tableau pour les miles. 
            //double[] entrekm = new double[n] { };// tableau pour les km.
            


            //if (testnombre == true)
            //{
            //    Distance = Distance / 1.609;

            //    Console.WriteLine("la distance est de :" + Math.Round(Distance, 3) + " miles");

            //}

            //else
            //{



            //    string sschaine = Dist.Substring(Dist.Length - 2,2);
            //    Distance = double.Parse((Dist.Substring(0, (Dist.Length - 2))));
            //    if (sschaine == "mi")
            //    {
            //        Distance = Distance * 1.609;
            //        Console.WriteLine("la distance est  de: " + Math.Round(Distance,3) + " km");

            //    }

            //    else if (sschaine == "km")
            //    {
            //        Distance = Distance / 1.609;

            //        Console.WriteLine("la distance est de :" + Math.Round(Distance,3) + " miles");
            //    }
            //    else
            //    {
            //        Console.WriteLine("conversion impossible, unité inconnue!!");
            //    }
            //}
        }
    }
}
            
        

    
