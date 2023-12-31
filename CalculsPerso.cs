/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de g�n�ration de nombre al�atoire
            int val1, val2; // m�morisation de nombres al�atoires
            int solution; // calcul de la solution
            int reponse = 0; // saisie de la r�ponse de l'utilisateur
            string choix; // saisie du choix de l'utilsiateur
            bool correct; // m�morise si la saisie est un entier

            // boucle sur le menu
            choix = "1";
            while (choix != "0")
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                choix = Console.ReadLine();
                // traitement des choix
                switch (choix)
                {
                    case "1": // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                // saisie de la r�ponse
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier");
                            }
                        }
                        // comparaison avec la bonne r�ponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                        break;
                    case "2": // multiplication
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la r�ponse
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier");
                            }
                        }
                        // comparaison avec la bonne r�ponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                        break;
                    case "0": //demande la fin du programme
                        break;
                    default: // autre valeur donc erreur de saisie
                        Console.WriteLine("Erreur de saisie");
                        break;
                }
            }
        }
    }
}