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
    public class ImplPozicija : IPozicija
    {
        private readonly AppDbContext _dbContext;
        public ImplPozicija(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public string AddPozicija(Pozicija pozicija)
        {
            try
            {
                _dbContext.pozicija.Add(pozicija);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeletePozicija(int id)
        {
            try
            {
                var pozicija = _dbContext.pozicija.Find(id);
                _dbContext.pozicija.Remove(pozicija);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Pozicija GetPozicija(int id)
        {
            return _dbContext.pozicija.Find(id);
        }

        public List<Pozicija> GetSvePozicije()
        {
            return _dbContext.pozicija.ToList();
        }

        public string UpdatePozicija(Pozicija pozicija)
        {
            try
            {
                var pozicija_rez = _dbContext.pozicija.Find(pozicija.Id);
                if (pozicija_rez != null)
                {
                    pozicija_rez.Naziv = pozicija.Naziv;
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
