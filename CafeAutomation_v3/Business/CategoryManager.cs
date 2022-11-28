
using CafeAutomation_v3.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation_v3.Business
{
    public class CategoryManager : Icrud<Category>
    {
        CafeAutomationEntities _context = new CafeAutomationEntities();

        public void Add(Category entity)
        {
            _context.Category.Add(entity);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var category = _context.Category.FirstOrDefault(x=> x.Id==id);
            _context.Category.Remove(category);
            _context.SaveChanges();
        }

        public Category Get(int id)
        {
            var category = _context.Category.FirstOrDefault(x => x.Id == id);
            return category;
        }

        public List<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        public void Update(Category entity)
        {
            var category = _context.Category.FirstOrDefault(x => x.Id == entity.Id);
            category.Name = entity.Name;
            _context.SaveChanges();
        }
    }
}
