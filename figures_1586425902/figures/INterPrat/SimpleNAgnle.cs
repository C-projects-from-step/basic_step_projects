using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterPrat
{
    interface ISimpleNAgnle
    {
        double Height { get; set; }
        double Base { get; set; }
        double Angel { get; set; }
        int NumSides { get;  }
        double  this [int pos] { get; set; }
      
    }
}
