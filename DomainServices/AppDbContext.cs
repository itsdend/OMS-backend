using DomainModel.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Options) : base(Options) { }
        public DbSet<Uloga> uloga { get;set;}
        public DbSet<Tim> tim { get; set; }
        public DbSet<Kategorijaopreme> kategorijaopreme { get; set; }
        public DbSet<Oprema> oprema { get; set; }
        public DbSet<Osoba> osoba { get; set; }
        public DbSet<Pozicija> pozicija { get; set; }
        public DbSet<Statusopreme> statusopreme { get; set; }

    }
}
