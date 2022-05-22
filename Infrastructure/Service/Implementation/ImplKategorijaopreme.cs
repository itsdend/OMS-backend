using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainServices;
using DomainModel.Model;
using Infrastructure.Service.Contract_interface;

namespace Infrastructure.Service.Implementation
{
    public class ImplKategorijaopreme : IKategorijaopreme
    {
        private readonly AppDbContext _dbContext;
        public ImplKategorijaopreme(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public string AddKategorijaopreme(Kategorijaopreme kategorijaopreme)
        {
            try
            {
                _dbContext.kategorijaopreme.Add(kategorijaopreme);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteKategorijaopreme(int id)
        {
            try
            {
                var kategorijaopreme = _dbContext.kategorijaopreme.Find(id);
                _dbContext.kategorijaopreme.Remove(kategorijaopreme);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Kategorijaopreme GetKategorijaopreme(int id)
        {
            return _dbContext.kategorijaopreme.Find(id);
        }

        public List<Kategorijaopreme> GetSveKategorijeopreme()
        {
            return _dbContext.kategorijaopreme.ToList();
        }

        public string UpdateKategorijaopreme(Kategorijaopreme kategorijaopreme)
        {
            try
            {
                var kategorijaopreme_rez = _dbContext.kategorijaopreme.Find(kategorijaopreme.Id);
                if (kategorijaopreme_rez != null)
                {
                    kategorijaopreme_rez.Naziv = kategorijaopreme.Naziv;
                    _dbContext.SaveChanges();
                    return "ok";
                }
                else
                {
                    return "error";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
