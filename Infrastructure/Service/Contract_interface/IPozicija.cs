using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service.Contract_interface
{
    public interface IPozicija
    {
        List<Pozicija> GetSvePozicije();
        Pozicija GetPozicija(int id);
        string AddPozicija(Pozicija pozicija);
        string UpdatePozicija(Pozicija pozicija);
        string DeletePozicija(int id);
    }
}
