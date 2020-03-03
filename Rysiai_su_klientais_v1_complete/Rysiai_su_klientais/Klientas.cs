using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rysiai_su_klientais
{
    public class Klientas
    {
        public Klientas(string prisijungimoVardas, string slaptazodis, string vardas, string pavarde, string ePastas, string miestas, string telefonoNr, string gimtadienis)
        {
            PrisijungimoVardas = prisijungimoVardas;
            Slaptazodis = slaptazodis;
            Vardas = vardas;
            Pavarde = pavarde;
            EPastas = ePastas;
            Miestas = miestas;
            TelefonoNr = telefonoNr;
            Gimtadienis = gimtadienis;
        }

        public string PrisijungimoVardas { get; set; }
        public string Slaptazodis { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string EPastas { get; set; }
        public string Miestas { get; set; }
        public string TelefonoNr { get; set; }
        public string Gimtadienis { get; set; }
    }
}
