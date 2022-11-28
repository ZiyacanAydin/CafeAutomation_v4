using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAutomation_v3.Business
{
    public interface Icrud<T>
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        List<T> GetAll();
        T Get(int id);
    }
}
