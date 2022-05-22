using DomainServices;
using DomainModel.Model;
using Infrastructure.Service.Contract_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service.Implementation
{
    public class ImplTim : ITim
    {
        private readonly AppDbContext _dbContext;
        public ImplTim(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public string AddTim(Tim tim)
        {
            try
            {
                _dbContext.tim.Add(tim);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteTim(int id)
        {
            try
            {
                var tim = _dbContext.tim.Find(id);
                _dbContext.tim.Remove(tim);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Tim> GetSveTimove()
        {

            return _dbContext.tim.ToList();
        }

        public Tim GetTim(int id)
        {
            return _dbContext.tim.Find(id);
        }

        public string UpdateTim(Tim tim)
        {
            try
            {
                var tim_rez = _dbContext.tim.Find(tim.Id);
                if (tim_rez != null)
                {
                    tim_rez.Naziv = tim.Naziv;
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
