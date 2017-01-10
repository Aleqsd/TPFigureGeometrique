using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Avec un tableau
            Console.WriteLine("Avec un tableau : ");
            Console.WriteLine("");
            Figure[] Figures = new Figure[2];
            Figures[0] = new Cercle(10);
            Figures[1] = new Rectangle(3, 4, 15, 10);

            
            Figures[0].Informations();
            Console.WriteLine("A une surface de " + String.Format("{0:0.00}",Figures[0].Surface()));

            Figures[1].Informations();
            Console.WriteLine("A une surface de " + String.Format("{0:0.00}",Figures[1].Surface()));
            double surfaceTotale = Figures[0].Surface() + Figures[1].Surface();
            Console.WriteLine("La surface totale de toutes les figures est : " + String.Format("{0:0.00}",surfaceTotale));
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
