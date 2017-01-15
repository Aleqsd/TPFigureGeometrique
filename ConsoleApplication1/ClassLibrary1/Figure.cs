using System;

// Developed by :
// Alexandre DO-O ALMEIDA
// Louis BEAUMONT
// 16/01/2017

namespace ClassLibrary
{
    // Classe publique afin d'être utilisée dans notre projet ConsoleApplication
    public class Figure
    {
        private double _x = 1;
        private double _y = 1;

        public double Y // Accesseur pour l'attribut _y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        public double X // Accesseur pour l'attribut _x
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public Figure() // Constructeur de base nécessaire pour les classes filles
        {

        }

        public Figure(double x, double y) // Constructeur initialisant _x et _y
        {
            _x = x;
            _y = y;
        }

        public virtual double Surface() // Calcul de la surface "virtual" à implémenter dans les classes filles
        {
            return 0;
        }

        public void Informations() // Affichage des coordonnées
        {
            Console.WriteLine("Le "+this.ToString().Substring(this.ToString().LastIndexOf('.') + 1) +" est centré en : \nx : " + this._x + "\ny : " + this._y);
        }
    }
}
