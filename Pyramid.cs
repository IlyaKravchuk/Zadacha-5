using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Pyramid
    {
        protected Single _edge, _basis, _var;
        protected Double _height, _volume, _Par_Vol, _Volume2;
        public Pyramid(Single basis, Single edge, Single var)
        {
            _edge = edge;
            _basis = basis;
            _var = var;
            _height = Math.Sqrt(Math.Pow(edge, 2) - (1 / 3) * Math.Pow(basis, 2));
            _volume = (Math.Sqrt(3) / 12) * _height * Math.Pow(basis, 2);
            _Par_Vol = 6 * _volume;
            _Volume2 = (Math.Sqrt(3) / 12) * (_height - _var) * Math.Pow((_height - _var) * _basis / _height, 2);
        }
    
        public double Parallelepiped
        {
            get { return _Par_Vol; }
        }
        public double Pyramid2
        {
            get { return _Volume2; }
        }
        public double height
        {
            get { return _height; }
        }
        public double Volume
        {
            get { return _volume; }
        }
    }    
}
