using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service.Contract_interface
{
    public interface IUloga
    {
        List<Uloga> GetSveUloge();
        Uloga GetUloga(int id);
        string AddUloga(Uloga uloga);
        string UpdateUloga(Uloga uloga);
        string DeleteUloga(int id);
    }
}
