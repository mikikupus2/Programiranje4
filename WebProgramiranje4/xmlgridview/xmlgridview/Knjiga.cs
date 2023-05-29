using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xmlgridview
{
    public class Knjiga
    {
        string isbn;
        string naslov;
        int stanje;
        int citano;

        public Knjiga(string isbn, string naslov, int stanje, int citano)
        {
            this.isbn = isbn;
            this.naslov = naslov;
            this.stanje = stanje;
            this.citano = citano;
        }

        public string Isbn { get => isbn; set => isbn = value; }
        public string Naslov { get => naslov; set => naslov = value; }
        public int Stanje { get => stanje; set => stanje = value; }
        public int Citano { get => citano; set => citano = value; }
    }
}