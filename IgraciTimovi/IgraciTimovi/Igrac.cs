using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraciTimovi
{
    class Igrac
    {
        public string Ime {get; set;}

        public Igrac (string ime)
        {
            Ime = ime;
        }

        public override string ToString()
        {
            return Ime;
        }
    }
}
