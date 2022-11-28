
using CafeAutomation_v3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation_v3.Business
{
    public class KasaManager : Icrud<Kasa>
    {
        CafeAutomationEntities _context = new CafeAutomationEntities();
        public void Add(Kasa entity)
        {
            _context.Kasa.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var kasa = _context.Kasa.FirstOrDefault(x => x.Id == id);
            _context.Kasa.Remove(kasa);
            _context.SaveChanges();
        }

        public Kasa Get(int id)
        {
            var kasa = _context.Kasa.FirstOrDefault(x => x.Id == id);
            return kasa;
        }

        public List<Kasa> GetAll()
        {
            return _context.Kasa.ToList();
        }

        public void Update(Kasa entity)
        {
            var kasa = _context.Kasa.FirstOrDefault(x => x.Id == entity.Id);
            kasa.ProductId = entity.ProductId;
            kasa.TableId = entity.TableId;
            kasa.SalesId = entity.SalesId;
            kasa.OrderTime = entity.OrderTime;
            kasa.Count = entity.Count;
            _context.SaveChanges();
        }
    }
}
