using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service.Contract_interface
{
    public interface IOsoba
    {
        List<Osoba> GetSveOsobe();
        Osoba GetOsoba(int id);
        string AddOsoba(Osoba osoba);
        string UpdateOsoba(Osoba osoba);
        string DeleteOsoba(int id);
    }
}
