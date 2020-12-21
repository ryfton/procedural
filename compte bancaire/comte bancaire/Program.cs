using System;

namespace comte_bancaire
{
    class Program
    {
        static void Main()
        {
            Compte c = new Compte();
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Console.WriteLine(c.ToString());
            Console.WriteLine(c1.ToString());
        }

    }

    internal class Compte : Comp
    {
        public Compte()
        {
        }

        public Compte(int v1, string v2, int v3, int v4)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
        }

        public int V1 { get; }
        public string V2 { get; }
        public int V3 { get; }
        public int V4 { get; }
    }
    class Comp
    {
        private int decouvertAutoriserInt;
        private int nomString;
        private int numeroInt;
        private int soldeInt;

        static void Compte(string[] args)
        {
            
            
        }

        public void CompteInt_numeroString_nomInt_soldeInt_decouvertAutaurise()
        {
            
        }

        public void CrediterInt_montantVoid()
        {
            
        }

        public void DebiterInt_montantBool()
        {
            
        }

        public void SuperieurCompte_autreCompteBool()
        {
            
        }

        public void TransfererInt_montantCompte_compteDestinataireBool()
        {
            
        }

        public void ToStringString()
        {
            
        }
    }
    
}
