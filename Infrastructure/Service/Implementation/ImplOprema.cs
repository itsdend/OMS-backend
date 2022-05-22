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
    public class ImplOprema : IOprema
    {
        private readonly AppDbContext _dbContext;
        public ImplOprema(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public string AddOprema(Oprema oprema)
        {
            try
            {
                _dbContext.oprema.Add(oprema);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteOprema(int id)
        {
            try
            {
                var oprema = _dbContext.oprema.Find(id);
                _dbContext.oprema.Remove(oprema);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Oprema GetOprema(int id)
        {
            return _dbContext.oprema.Find(id);
        }

        public List<Oprema> GetSveOpreme()
        {
            return _dbContext.oprema.ToList();
        }

        public string UpdateOprema(Oprema oprema)
        {
            try
            {
                var oprema_rez = _dbContext.oprema.Find(oprema.Id);
                if (oprema_rez != null)
                {
                    oprema_rez.Naziv = oprema.Naziv;
                    oprema_rez.Opis = oprema.Opis; 
                    oprema_rez.Serijskibroj =  oprema.Serijskibroj;
                    oprema_rez.Datumkupnje = oprema.Datumkupnje;   
                    oprema_rez.FkStatusid = oprema.FkStatusid;
                    oprema_rez.Cijena = oprema.Cijena;
                    oprema_rez.FkKategorijaid = oprema.FkKategorijaid;
                    oprema_rez.FkPrethodnivlasnikid = oprema.FkPrethodnivlasnikid;
                    oprema_rez.FkTrenutnivlasnikid = oprema.FkTrenutnivlasnikid;
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
