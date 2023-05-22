using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDF;

namespace PDF
{
    internal class Poulailler
    {

            int nbP;
        int nbMaxP;
            public int NbMaxP
            {
                get { return nbMaxP; }
                set
                {
                    nbMaxP = value;
                    poulaillerA = new Poule[nbMaxP];
                    
            }
            }
            Poule[] poulaillerA;
            Poule[] poulaillerB;

        public Poulailler()
            {
                poulaillerA = new Poule[nbMaxP];
                poulaillerB = new Poule[nbMaxP];
            }

            public void AjouterP(string nom, string race, double intensitePonte, Taille taillePoule)
            {
                Poule Vickie = new Poule(nom, race, intensitePonte, taillePoule);
                for (int i = 0; i < nbMaxP; i++)
                {
                    
                if (poulaillerA[i] == null)
                {
                    poulaillerA[i] = Vickie;
                    nbP++;
                    Console.WriteLine("Poule ajoutée avec succès !");
                    return;
                }
                else
                {
                    poulaillerB = Vickie;

                }
            }
            Console.WriteLine("nombre Max de poule atteint dans le poulailler");

        }

            public void SupprimerPoule(string nom)
            {
                for (int i = 0; i < nbP; i++)
                {
                    if (poulaillerA[i].Nom == nom)
                    {
                        for (int j = i; j < nbP - 1; j++)
                        {
                            poulaillerA[j] = poulaillerA[j + 1];
                        }
                        nbP--;
                        Console.WriteLine("Poule supprimée avec succès !");
                        return;
                    }
                }
                Console.WriteLine("Aucune poule portant ce nom n'a été trouvée.");
            }

            public void Affiche()
                {
                    for (int i = 0; i < nbP; i++)
                    {
                        Console.WriteLine($"{poulaillerA[i].Nom} ({poulaillerA[i].Race})");
                        
                    }
                    return;
                }
    }
}
