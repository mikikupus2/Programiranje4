using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Napisati program koji omogucava:
1)Rad sa generickom listom ciji su elementi objekti klase Student. Lista podatke dobija iz tabele student, baze Fakultet2019,
izvrsavanjem upita ciji tekst
korisnik unosi u rich textbox na posebnoj formi.
2)Prikaz liste u kontroli DataGridView
3)Uklanjanje ili izbacivanje iz liste studenta ciji se broj indexa unosi kao parametar
4)Brisanje sadrzaja cele liste
5)Sortiranje liste po broju indexa u rastucem poretku, koje se pokrece iz context menija vezanog za kontrolu ListBox cijim 
stavkama su prikazani broj,ime i prezime
ListBox postaviti na formi1 i on u svakom tretnutku odrazava trenutno stanje liste.*/

namespace StudentBaza
{
    public class Student
    {
        private string brojindeksa;
        private string ime;
        private string prezime;
        private string adresa;
        private DateTime datumrodjenja;
        private byte godinastudija;
        private long ptt;
        public string Brojindeksa { get => brojindeksa; set => brojindeksa = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public DateTime Datumrodjenja { get => datumrodjenja; set => datumrodjenja = value; }
        public byte Godinastudija { get => godinastudija; set => godinastudija = value; }
        public long Ptt { get => ptt; set => ptt = value; }
    }
}
