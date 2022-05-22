using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service.Contract_interface
{
    public interface IKategorijaopreme
    {
        List<Kategorijaopreme> GetSveKategorijeopreme();
        Kategorijaopreme GetKategorijaopreme(int id);
        string AddKategorijaopreme(Kategorijaopreme kategorijaopreme);
        string UpdateKategorijaopreme(Kategorijaopreme kategorijaopreme);
        string DeleteKategorijaopreme(int id);
    }
}
