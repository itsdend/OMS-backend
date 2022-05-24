using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service.Contract_interface
{
    public interface IOprema
    {
        List<Oprema> GetSveOpreme();
        Oprema GetOprema(int id);
        List<Oprema> GetOpremaByUser(int osobaid);
        string AddOprema(Oprema oprema);
        string UpdateOprema(Oprema oprema);
        string DeleteOprema(int id);
    }
}
