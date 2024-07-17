using dataAccessLayer.abstracts;
using dataAccessLayer.concrete;
using dataAccessLayer.concrete.repositories;
using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.entityFramework
{
    public class efAuthorDal : genericRepository<authorTable>, IAuthorDal
    {
        public efAuthorDal(context context) : base(context)
        {
        }
    }
}
