
using CafeAutomation_v3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeAutomation_v3.Business
{
    public class SalesManager : Icrud<Sales>
    {
        CafeAutomationEntities _context = new CafeAutomationEntities();
        public void Add(Sales entity)
        {
            _context.Sales.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var sales = _context.Sales.FirstOrDefault(x => x.Id == id);
            _context.Sales.Remove(sales);
            _context.SaveChanges();
        }

        public Sales Get(int id)
        {
            var sales = _context.Sales.FirstOrDefault(x => x.Id == id);
            return sales;
        }

        public List<Sales> GetAll()
        {
            return _context.Sales.ToList();
        }

        public void Update(Sales entity)
        {
            var sales = _context.Sales.FirstOrDefault(x => x.Id == entity.Id);
            sales.ProductId = entity.ProductId;
            sales.TableId = entity.TableId;
            sales.DateTime = entity.DateTime;
            sales.count = entity.count;
            _context.SaveChanges();
        }
    }
}
