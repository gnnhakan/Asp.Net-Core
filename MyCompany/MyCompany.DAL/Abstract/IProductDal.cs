using MyCompany.Core.DataAccess;
using MyCompany.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.DAL.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
