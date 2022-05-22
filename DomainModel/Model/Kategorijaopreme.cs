using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainModel.Model
{
    public class Kategorijaopreme
    {
        [Key]
        public int Id { get; set; }
        public string? Naziv { get; set; } = null!;

    }
}
