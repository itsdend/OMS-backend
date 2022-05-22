using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service.Contract_interface
{
    public interface ITim
    {
        List<Tim> GetSveTimove();
        Tim GetTim(int id);
        string AddTim(Tim tim);
        string UpdateTim(Tim tim);
        string DeleteTim(int id);
    }
}
