using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace upload3.Models
{
    public class Raspored
    {
        public int Redni_Broj_Casa{ get; set; }
        public string Dan { get; set; }
        public string Predmet { get; set; }

        public Raspored(int Redni_Broj_Casa, string Dan, string Predmet)
        {
            this.Redni_Broj_Casa = Redni_Broj_Casa;
            this.Dan = Dan ?? throw new ArgumentNullException(nameof(Dan));
            this.Predmet = Predmet ?? throw new ArgumentNullException(nameof(Predmet));
        }
    }
}