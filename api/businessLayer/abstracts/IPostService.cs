using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.abstracts
{
    public interface IPostService
    {
        void insert(postTable p);
        void update(postTable p);
        void delete(postTable p);
        List<postTable> getAll();
        postTable getById(int id);

        List<postTable> List(Expression<Func<postTable, bool>> filter);
    }
}
