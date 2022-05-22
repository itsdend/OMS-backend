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
    public class ImplOsoba : IOsoba
    {
        private readonly AppDbContext _dbContext;
        public ImplOsoba(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public string AddOsoba(Osoba osoba)
        {
            try
            {
                using (var sha = new System.Security.Cryptography.SHA256Managed())
                {
                    byte[] textData = System.Text.Encoding.UTF8.GetBytes(osoba.Lozinka);
                    byte[] hash = sha.ComputeHash(textData);
                    osoba.Lozinka = BitConverter.ToString(hash).Replace("-", String.Empty);
                }
                _dbContext.osoba.Add(osoba);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteOsoba(int id)
        {
            try
            {
                var osoba = _dbContext.osoba.Find(id);
                _dbContext.osoba.Remove(osoba);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Osoba GetOsoba(int id)
        {
            return _dbContext.osoba.Find(id);
        }

        public List<Osoba> GetSveOsobe()
        {
            return _dbContext.osoba.ToList();
        }

        public string UpdateOsoba(Osoba osoba)
        {
            try
            {
                var osoba_rez = _dbContext.osoba.Find(osoba.Id);
                if (osoba_rez != null)
                {
                    osoba_rez.Oib = osoba.Oib;
                    osoba_rez.Datumrodenja = osoba.Datumrodenja;
                    osoba_rez.Datumzaposljenja = osoba.Datumzaposljenja;
                    osoba_rez.Email = osoba.Email;
                    osoba_rez.FkPozicijaid = osoba.FkPozicijaid;
                    osoba_rez.FkTimid = osoba.FkTimid;
                    osoba_rez.FkUlogaid = osoba.FkUlogaid;
                    osoba_rez.Ime = osoba.Ime;
                    osoba_rez.Jezaposlen = osoba.Jezaposlen;   
                    osoba_rez.Kontaktbr = osoba.Kontaktbr;
                    osoba_rez.Prezime = osoba.Prezime;
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
