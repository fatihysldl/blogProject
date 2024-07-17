using businessLayer.abstracts;
using dataAccessLayer.abstracts;
using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.concrete
{
    public class authorManager : IAuthorService
    {
        IAuthorDal _author;

        public authorManager(IAuthorDal author)
        {
            _author = author;
        }

        public void delete(authorTable p)
        {
            _author.delete(p);
        }

        public List<authorTable> getAll()
        {
            return _author.getAll();
        }

        public authorTable getById(int id)
        {
            return _author.getById(id);
        }

        public void insert(authorTable p)
        {
            _author.insert(p);
        }

        public List<authorTable> List(Expression<Func<authorTable, bool>> filter)
        {
            return _author.List(filter);
        }

        public void update(authorTable p)
        {
            _author.update(p);
        }
    }
}
