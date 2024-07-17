using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.abstracts
{
    public interface IAuthorService
    {
        void insert(authorTable p);
        void update(authorTable p);
        void delete(authorTable p);
        List<authorTable> getAll();
        authorTable getById(int id);

        List<authorTable> List(Expression<Func<authorTable, bool>> filter);
    }
}
