using System;
using System.Collections.Generic;

// Intégration des classes de notre projet ClassLibrary
using ClassLibrary;

// Developed by :
// Alexandre DO-O ALMEIDA
// Louis BEAUMONT
// 16/01/2017

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Avec un tableau
            Console.WriteLine("Avec un tableau : ");
            Console.WriteLine("");
            Figure[] Figures = new Figure[2]; // Création d'un tableau de Figure de taille 2
            Figures[0] = new Cercle(10); // Ajout d'un Cercle de rayon 10 en première position du tableau
            Figures[1] = new Rectangle(3, 4, 15, 10); // Ajout d'un Rectangle en (3;4) de taille 15 sur 10
            // en deuxième position du tableau

            Figures[0].Informations(); // Affichage des coordonnées
            Console.WriteLine("A une surface de " + String.Format("{0:0.00}", Figures[0].Surface()));

            Figures[1].Informations(); // Affichage des coordonnées
            Console.WriteLine("A une surface de " + String.Format("{0:0.00}", Figures[1].Surface()));
            double surfaceTotale = Figures[0].Surface() + Figures[1].Surface();
            Console.WriteLine("La surface totale de toutes les figures est : " + String.Format("{0:0.00}", surfaceTotale));
            Console.WriteLine("");


            // Avec une liste
            Console.WriteLine("Avec une liste : ");
            Console.WriteLine("");
            List<Figure> Figures2 = new List<Figure>();
            Figures2.Add(new Cercle(10));
            Figures2.Add(new Rectangle(3, 4, 15, 10));

            Figures2[0].Informations();
            Console.WriteLine("A une surface de " + String.Format("{0:0.00}", Figures[0].Surface()));

            Figures2[1].Informations();
            Console.WriteLine("A une surface de " + String.Format("{0:0.00}", Figures[1].Surface()));
            Console.WriteLine("La surface totale de toutes les figures est : " + String.Format("{0:0.00}", surfaceTotale));

            Console.ReadLine();
        }
    }
}
