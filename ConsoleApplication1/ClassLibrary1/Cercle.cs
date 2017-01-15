using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cercle : Figure
    {
        private double _rayon;


        public double Rayon
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

        public Cercle(double rayon)
        {
            _rayon = rayon;
        }

        public Cercle(double x, double y, double rayon) : base(x,y)
        {
            _rayon = rayon;
        }

        public override double Surface()
        {
            return (_rayon * _rayon) * Math.PI;
        }

    }
}
