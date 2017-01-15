using System;

// Developed by :
// Alexandre DO-O ALMEIDA
// Louis BEAUMONT
// 16/01/2017

namespace ClassLibrary
{
    // Classe publique afin d'être utilisée dans notre projet ConsoleApplication
    public class Cercle : Figure
    {
        private double _rayon;


        public double Rayon // Accesseur pour l'attribut _rayon
        {
            get
            {
                return _rayon;
            }

            set
            {
                _rayon = value;
            }
        }

        public Cercle(double rayon) // Constructeur avec seulement l'attribut _rayon
        {
            _rayon = rayon;
        }

        public Cercle(double x, double y, double rayon) : base(x,y) // Constructeur avancé
        {
            _rayon = rayon;
        }

        public override double Surface() // Calcul de la surface S = R² * PI
        {
            return (_rayon * _rayon) * Math.PI;
        }

    }
}
