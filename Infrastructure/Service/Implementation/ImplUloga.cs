using DomainModel.Model;
using DomainServices;
using Infrastructure.Service.Contract_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service.Implementation
{
    public class ImplUloga : IUloga
    {
        private readonly AppDbContext _dbContext;
        public ImplUloga(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public string AddUloga(Uloga uloga)
        {
            try
            {
                _dbContext.uloga.Add(uloga);
                _dbContext.SaveChanges();
                return "ok";
            } catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteUloga(int id)
        {
            try
            {
                var uloga = _dbContext.uloga.Find(id);
                Console.WriteLine(uloga);
                _dbContext.uloga.Remove(uloga);
                _dbContext.SaveChanges();
                return "ok";
            } catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Uloga> GetSveUloge()
        {
            return _dbContext.uloga.ToList();
        }

        public Uloga GetUloga(int id)
        {
            //return _dbContext.uloga.Where(u => u.Id == id).FirstOrDefault();
            return _dbContext.uloga.Find(id);
        }

        public string UpdateUloga(Uloga uloga)
        {
            try
            {
                var uloga_rez = _dbContext.uloga.Find(uloga.Id);
                if (uloga_rez != null)
                {
                    uloga_rez.Naziv = uloga.Naziv;
                    _dbContext.SaveChanges();
                    return "ok";
                }
                else
                {
                    return "error";
                }
            } catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
