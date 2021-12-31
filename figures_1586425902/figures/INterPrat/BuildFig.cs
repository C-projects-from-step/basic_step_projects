using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterPrat
{
    class BuildFig
    {
        private GeometryFig[] _arr;
        

        //public int Length {


        //    get =>_arr.Length;
                                          
        //    set =>Length=_arr.Length; }

        public GeometryFig this[int pos]
        {
            get => _arr[pos];
            set => _arr[pos] = value;
        }

       

        public BuildFig()
        {
            _arr = new GeometryFig[0];

        }

        public void Add(GeometryFig obj)
        {
            int m = _arr.Length + 1;
            Array.Resize(ref _arr, m);
            _arr[m-1] = obj;
        }


        public void Del(int pos)
        {
            if (pos < 0 || pos >= _arr.Length)
                return;
            GeometryFig[] tmp = new GeometryFig[_arr.Length-1];
            for (int i = 0, j=0; i <_arr.Length; i++)
            {
                if (i != pos)
                    tmp[j++] = _arr[i];
               
            }
            _arr = tmp;
        }

        public double TotalSqueare()
        {
            double m = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
               m+= _arr[i].Square();
            }

            return m;
        }

    }
}
