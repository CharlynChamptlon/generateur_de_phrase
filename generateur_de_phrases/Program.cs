using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace generateur_de_phrases
{
    class Program
    {

        static string ObtenirElementAleatoire(string[] tableau)
        {
            var rand = new Random();
            int nb = rand.Next(tableau.Length);
            string nom = tableau[nb];
            return nom;
        }
        static void Main(string[] args)
        {
            //sujet verbes complément

            var sujets = new string[]
            {
                "Une lapin",
                "Une mémé",
                "Un kangourou",
                "Un haricot",
                "Un grenouille",
                "Une vache",
                "Un pissenlit",
                "Un clou",
                "Un magicien",
                "Bernard",
                "Une chaise",
                "Un ornithorinque",
                "Une fourchette",
                "Un bonhomme de neige"
            };

            var verbes = new string[]
            {
                "mange",
                "se bat avec",
                "avale",
                "écrase",
                "détruit",
                "joue avec",
                "regarde",
                "attrape",
                "s'accroche à",
                "nettoie"
            };

            var complements = new string[]
            {
                "un arbre",
                "la lune",
                "le soleil",
                "une souris",
                "le ciel",
                "une piscine",
                "un livre",
                "un savon",
                "un gâteau",
                "une girafe",
                "une carte"
            };

            const int NB_PHRASES = 200;
            int repete = 0;
            var liste_phrases = new List<string>();
            int i = 0;
            while (i < NB_PHRASES)
            {
                string sujet = ObtenirElementAleatoire(sujets);
                string verbe = ObtenirElementAleatoire(verbes);
                string complement = ObtenirElementAleatoire(complements);
                string phrase = sujet + " " + verbe + " " + complement;
                phrase = phrase.Replace("à le","au");
                if (liste_phrases.Contains(phrase))
                {
                    repete++;
                }
                else
                {
                    liste_phrases.Add(phrase);
                    i++;
                    Console.WriteLine(phrase);
                }

            }

            Console.WriteLine($"Nombre de phrases : {NB_PHRASES}");
            Console.WriteLine($"Nombre de doublons évités : {repete}");

        }
    }
}
