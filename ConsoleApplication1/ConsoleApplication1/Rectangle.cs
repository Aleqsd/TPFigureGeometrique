using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rectangle : Figure
    {
        private double _longueur;
        private double _largeur;

        public double Longueur
        {
            get
            {
                return _longueur;
            }

            set
            {
                _longueur = value;
            }
        }

        public double Largeur
        {
            get
            {
                return _largeur;
            }

            set
            {
                _largeur = value;
            }
        }

        public Rectangle(double longueur, double largeur)
        {
            _longueur = longueur;
            _largeur = largeur;
        }

        public Rectangle(double x, double y, double longueur, double largeur) : base(x,y)
        {
            _longueur = longueur;
            _largeur = largeur;
        }

        public override double Surface()
        {
            return _longueur * _largeur;
        }


    }
}
