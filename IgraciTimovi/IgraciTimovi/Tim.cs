using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraciTimovi
{
    class Tim
    {
        public List<Igrac> listaIgracaUTimu;

        public string Ime { get; set; }

        public Tim(string ime)
        {
            Ime = ime;

            listaIgracaUTimu = new List<Igrac>();
        }

        public override string ToString()
        {
            return Ime;
        }

        public bool DodajIgraca(Igrac odabraniIgrac)
        {
            if (listaIgracaUTimu.Count >= 11)
            {
                return true;
            }
            else
            {
                listaIgracaUTimu.Add(odabraniIgrac);
                return false;
            }
        }

        public void IzbrisiIgraca(Igrac odabraniIgrac)
        {
            listaIgracaUTimu.Remove(odabraniIgrac);
        }
    }
}
