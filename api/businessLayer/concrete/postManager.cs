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
    public class postManager : IPostService
    {
        IPostDal _post;

        public postManager(IPostDal post)
        {
            _post = post;
        }

        public void delete(postTable p)
        {
            _post.delete(p);
        }

        public List<postTable> getAll()
        {
            return _post.getAll();
        }

        public postTable getById(int id)
        {
            return _post.getById(id);
        }

        public void insert(postTable p)
        {
            _post.insert(p);
        }

        public List<postTable> List(Expression<Func<postTable, bool>> filter)
        {
            return _post.List(filter);
        }

        public void update(postTable p)
        {
            _post.update(p);
        }
    }
}
