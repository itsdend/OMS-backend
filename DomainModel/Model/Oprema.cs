using System;
using System.Collections.Generic;

namespace DomainModel.Model
{
    public class Oprema
    {
        public int Id { get; set; }
        public string? Naziv { get; set; } = null!;
        public decimal? Cijena { get; set; }
        public DateOnly? Datumkupnje { get; set; }
        public string? Serijskibroj { get; set; }
        public string? Opis { get; set; }
        public int? FkKategorijaid { get; set; }
        public int? FkTrenutnivlasnikid { get; set; }
        public int? FkPrethodnivlasnikid { get; set; }
        public int? FkStatusid { get; set; }

    }
}
