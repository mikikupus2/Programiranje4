//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCUcenici.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ucenik
    {
        public int ID { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public string Pol { get; set; }
        public string Email { get; set; }
        public string Razred_i_Odeljenje { get; set; }
        public Nullable<double> Prosecna_Ocena { get; set; }
    }
}
