using System;
using System.Collections.Generic;

namespace DomainModel.Model
{
    public partial class Osoba
    {
       

        public int Id { get; set; }
        public string? Oib { get; set; } = null!;
        public string? Ime { get; set; } = null!;
        public string? Prezime { get; set; } = null!;
        public DateOnly? Datumrodenja { get; set; }
        public DateOnly? Datumzaposljenja { get; set; }
        public string? Lozinka { get; set; } = null!;
        public string? Email { get; set; } = null!;
        public string? Kontaktbr { get; set; }
        public bool? Jezaposlen { get; set; }
        public int? FkTimid { get; set; }
        public int? FkUlogaid { get; set; }
        public int? FkPozicijaid { get; set; }

    }
}
