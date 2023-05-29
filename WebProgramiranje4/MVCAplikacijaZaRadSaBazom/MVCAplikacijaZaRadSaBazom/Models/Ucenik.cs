using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAplikacijaZaRadSaBazom.Models
{
    public class Ucenik
    {
        private int id;
        private string prezime;
        private string ime;
        private string pol;
        private string email;
        private string razred_i_odeljenje;
        private float prosecna_ocena;

        public int Id { get => id; set => id = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Pol { get => pol; set => pol = value; }
        public string Email { get => email; set => email = value; }
        public string Razred_i_odeljenje { get => razred_i_odeljenje; set => razred_i_odeljenje = value; }
        public float Prosecna_ocena { get => prosecna_ocena; set => prosecna_ocena = value; }

        public Ucenik(int id, string prezime, string ime, string pol, string email, string razred_i_odeljenje, float prosecna_ocena)
        {
            this.Id = id;
            this.Prezime = prezime ?? throw new ArgumentNullException(nameof(prezime));
            this.Ime = ime ?? throw new ArgumentNullException(nameof(ime));
            this.Pol = pol ?? throw new ArgumentNullException(nameof(pol));
            this.Email = email ?? throw new ArgumentNullException(nameof(email));
            this.Razred_i_odeljenje = razred_i_odeljenje ?? throw new ArgumentNullException(nameof(razred_i_odeljenje));
            this.Prosecna_ocena = prosecna_ocena;
        }
    }
}