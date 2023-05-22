using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDF;

namespace PDF
{
    /// <summary>
    /// Modélise une poule
    /// </summary>
    public class Poule
    {
        
        /// <summary>
        /// Nom de la poule
        /// </summary>
        /// <example>Germaine, Roussette, Ginger, Raymonde</example>
        public string Nom { get; set; }

        /// <summary>
        /// Race de la poule
        /// </summary>
        /// <example>Sussex, Marans, Gatinaise, Gauloise</example>
        public string Race { get; set; }

        /// <summary>
        /// Nb moyen d'oeufs pondus par jour
        /// </summary>
        public double IntensitePonte { get; set; }

        /// <summary>
        /// Taille de la poule
        /// </summary>
        /// <remarks>S jusque XXL</remarks>
        public Taille Taille { get; set; }




        /// <summary>
        /// Création d'une nouvelle instance d'un objet Poule
        /// </summary>
        /// <param name="nomP">Nom</param>
        /// <param name="raceP">Race</param>
        /// <param name="intensiteP">Intensite de ponte</param>
        /// <param name="tailleP">Taille</param>
        public Poule(string nomP, string raceP, double intensiteP, Taille tailleP)
        {
            Nom = nomP;
            Race = raceP;
            IntensitePonte = intensiteP;
            Taille = tailleP;
        }

        /// <summary>
        /// Affiche le nom et la race
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine($"{Nom} ({Race})");
        }
    }
}
