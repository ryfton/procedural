using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace annéeBissextile
{
    class Program
    {
        static void Main(string[] args)
        {
            int année;
            bool annéeBissextile=true;
            Console.WriteLine("Ce programme permet de déterminer si une année est bissextile ou non, veuillez saisir votre date : ");

             année=(int.Parse(Console.ReadLine()));

               AnnéeBissextile(année, ref annéeBissextile);
                                
            Console.WriteLine();
            Console.ReadKey();

        }
        public static void  AnnéeBissextile( int _a,ref bool _annéeBissextile)
        {
             
            if (_a % 4 != 0)
            {
                _annéeBissextile = false;
            }
            else
            {
                if ((_a % 100 == 0) && (_a % 400 != 0))
                {
                    _annéeBissextile = false;
                }
                else
                {
                    _annéeBissextile = true;
                }
                
            }
           
            
            
            

        }
       
    }
}
