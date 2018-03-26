using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms1
{
    class Trosak
    {
        float iznos;
        //enum Kategorije { hrana, zabava, zdravlje, edukacija }; nisam koristio enum
        string kategorija;

        public Trosak( float _iznos, string _kategorija)
        {
            iznos = _iznos;
            kategorija = _kategorija;
        }

        public override string ToString()
        {
            return iznos.ToString() + " kn - " + kategorija;
        }
    }
}
