
using CafeAutomation_v3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation_v3.Business
{
    public class TableManager : Icrud<Table>
    {
        CafeAutomationEntities _context = new CafeAutomationEntities();
        public void Add(Table entity)
        {
            _context.Table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var table = _context.Table.FirstOrDefault(x => x.Id == id);
            _context.Table.Remove(table);
            _context.SaveChanges();
        }

        public Table Get(int id)
        {
            var table = _context.Table.FirstOrDefault(x => x.Id == id);
            return table;

        }

        public List<Table> GetAll()
        {
            return _context.Table.ToList();
        }

        public void Update(Table entity)
        {
            var table = _context.Table.FirstOrDefault(x => x.Id == entity.Id);
            table.Name = entity.Name;
            
            _context.SaveChanges();
        }
    }
}
