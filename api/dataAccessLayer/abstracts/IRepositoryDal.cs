using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.abstracts
{
    public interface IRepositoryDal<T> where T : class
    {
        void insert(T p);
        void update(T p);
        void delete(T p);
        List<T> getAll();
        T getById(int id);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
