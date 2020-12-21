using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPbanque
{
    public class Banque : Compte
    {
        //attributs
        private int nombreCompte;
        private Compte[] lesComptes;
        //Constructeur 

        public Banque()
        {
            lesComptes = new Compte[20];
            this.nombreCompte = 0;

        }
        //methodes
        private void AjouterCompte(Compte _unCompte)
        {

            this.lesComptes[nombreCompte] = _unCompte;
            nombreCompte++;
        }

        public void init()
        {
            Compte client1 = new Compte("123456", "Tournesol", 4500.50, -3000);

            Compte client2 = new Compte("678910", "Haddock", 500.50, -15000);
            Compte client3 = new Compte("101213", "Nestor", 4500, -500);
            this.AjouterCompte(client1);
            this.AjouterCompte(client2);
            this.AjouterCompte(client3);
        }
        public override string ToString()
        {
            string MesComptes = "";
            foreach (Compte unclient in this.lesComptes)
            {
                MesComptes += unclient.ToString() + "/n";
            }

            return MesComptes;

        }




    }



}
