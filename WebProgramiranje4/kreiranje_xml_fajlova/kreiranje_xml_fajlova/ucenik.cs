using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kreiranje_xml_fajlova
{
    public class ucenik
    {
        public int id;
        public string ime;
        public string prezime;
        public double prosek;

        public ucenik(int id, string ime, string prezime, double prosek)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.prosek = prosek;
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public double Prosek { get => prosek; set => prosek = value; }
    }
}