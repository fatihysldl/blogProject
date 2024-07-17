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
    public class efPostDal : genericRepository<postTable>, IPostDal
    {
        public efPostDal(context context) : base(context)
        {
        }
    }
}
