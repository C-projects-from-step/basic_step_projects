using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLfiles
{
    struct Bus
    {
        public string Brand { get; set; }
        public ConsoleColor Color { get; set; }
        public int NumPas { get; set; }
        public DateTime YearofCreation { get; set; }
        public bool Conditioner { get; set; }
    }
}
