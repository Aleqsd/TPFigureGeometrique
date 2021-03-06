﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Figure
    {
        private double _x = 1;
        private double _y = 1;

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

        }

        public Figure(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public virtual double Surface()
        {
            return 0;
        }

        public void Informations()
        {
            Console.WriteLine("Le "+this.ToString().Substring(this.ToString().LastIndexOf('.') + 1) +" est centré en : \nx : " + this._x + "\ny : " + this._y);
        }
    }
}
