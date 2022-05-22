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
    public class ImplStatusopreme : IStatusopreme
    {
        private readonly AppDbContext _dbContext;
        public ImplStatusopreme(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public string AddStatusopreme(Statusopreme statusopreme)
        {
            try
            {
                _dbContext.statusopreme.Add(statusopreme);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteStatusopreme(int id)
        {
            try
            {
                var statusopreme = _dbContext.statusopreme.Find(id);
                _dbContext.statusopreme.Remove(statusopreme);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Statusopreme GetStatusopreme(int id)
        {
            return _dbContext.statusopreme.Find(id);
        }

        public List<Statusopreme> GetSveStatuseopreme()
        {
            return _dbContext.statusopreme.ToList();
        }

        public string UpdateStatusopreme(Statusopreme statusopreme)
        {
            try
            {
                var statusopreme_rez = _dbContext.statusopreme.Find(statusopreme.Id);
                if (statusopreme_rez != null)
                {
                    statusopreme_rez.Naziv = statusopreme.Naziv;
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
