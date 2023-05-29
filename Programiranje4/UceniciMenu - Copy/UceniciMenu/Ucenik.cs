using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UceniciMenu
{
    public class Ucenik
    {
        static double ocena_ukupno;
        static double prosecna_ocena;
        static int broj_ucenika;
        int sifra;
        string ime;
        string prezime;
        string telefon;
        int ocena;

        public Ucenik(int sifra, string ime, string prezime, string telefon, int ocena)
        {
            this.Sifra = sifra;
            this.ime = ime;
            this.prezime = prezime;
            this.telefon = telefon;
            this.ocena = ocena;
            ocena_ukupno += ocena;
            broj_ucenika++;
            IzracunajProsecnuOcenu();
        }

        public static double Prosecna_ocena { get => prosecna_ocena; set => prosecna_ocena = value; }
        public static double Ocena_ukupno { get => ocena_ukupno; set => ocena_ukupno = value; }
        public static int Broj_ucenika { get => broj_ucenika; set => broj_ucenika = value; }
        public int Sifra { get => sifra; set => sifra = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public int Ocena { get => ocena; set => ocena = value; }
        public static void IzracunajProsecnuOcenu()
        {
            prosecna_ocena = ocena_ukupno / broj_ucenika;
        }
    }
}
