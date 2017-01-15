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

        public double Longueur // Accesseur pour l'attribut _longueur
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

        public double Largeur // Accesseur pour l'attribut _largeur
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

        public Rectangle(double longueur, double largeur) // Constructeur initialisant _longueur et _largeur
        {
            _longueur = longueur;
            _largeur = largeur;
        }

        public Rectangle(double x, double y, double longueur, double largeur) : base(x,y) // Constructeur avancé
        {
            _longueur = longueur;
            _largeur = largeur;
        }

        public override double Surface() // Calcul de la surface S = L * l
        {
            return _longueur * _largeur;
        }


    }
}
