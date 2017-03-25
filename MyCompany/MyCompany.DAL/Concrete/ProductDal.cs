
using MyCompany.Core.DataAccess.EntityFramework;
using MyCompany.DAL.Abstract;
using MyCompany.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.DAL.Concrete
{
    public class ProductDal : EfEntityRepositoryBase<Product, MyContext>, IProductDal
    {

    }
}
