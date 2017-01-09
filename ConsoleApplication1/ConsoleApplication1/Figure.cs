using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Figure
    {
        private double _x;
        private double _y;

        public double Y
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

        public double X
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

        public Figure()
        {
            _x = 1;
            _y = 1;
        }

        public Figure(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double Surface()
        {
            return 0;
        }

        public void Informations()
        {
            Console.WriteLine("La figure est centrée en : \n x : " + this._x + "\ny : " + this._y);
        }
    }
}
