using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBiblioteka.Models
{
    public class Knjiga
    {
        public int ISBN { get; set; }
        public int Stanje { get; set; }
        public int Citano { get; set; }
        public string Naziv { get; set; }

        public Knjiga(int ISBN, int Stanje, int Citano, string Naziv)
        {
            this.ISBN = ISBN;
            this.Stanje = Stanje;
            this.Citano = Citano;
            this.Naziv = Naziv;
        }
    }
}