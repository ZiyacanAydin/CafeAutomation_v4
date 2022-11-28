
using CafeAutomation_v3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeAutomation_v3.Business
{
    public class ProductManager : Icrud<Product>
    {  
        CafeAutomationEntities _context = new CafeAutomationEntities();
        public void Add(Product entity)
        {
            _context.Product.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Product.FirstOrDefault(x => x.Id == id);
            _context.Product.Remove(product);
            _context.SaveChanges();
        }

        public Product Get(int id)
        {
            var product = _context.Product.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public List<Product> GetAll()
        {
            return _context.Product.ToList();
        }

        public void Update(Product entity)
        {
            var product = _context.Product.FirstOrDefault(x => x.Id == entity.Id);
            product.CategoryId = entity.CategoryId;
            product.Name = entity.Name;
            product.Price = entity.Price;
            product.Description = entity.Description;
            _context.SaveChanges();
        }
    }
}
