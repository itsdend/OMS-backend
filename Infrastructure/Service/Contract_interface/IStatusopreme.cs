using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service.Contract_interface
{
    public interface IStatusopreme
    {
        List<Statusopreme> GetSveStatuseopreme();
        Statusopreme GetStatusopreme(int id);
        string AddStatusopreme(Statusopreme statusopreme);
        string UpdateStatusopreme(Statusopreme statusopreme);
        string DeleteStatusopreme(int id);
    }
}
