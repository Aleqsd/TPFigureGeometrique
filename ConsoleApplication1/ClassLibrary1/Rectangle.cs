// Developed by :
// Alexandre DO-O ALMEIDA
// Louis BEAUMONT
// 16/01/2017

namespace ClassLibrary
{
    // Classe publique afin d'être utilisée dans notre projet ConsoleApplication
    public class Rectangle : Figure
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
