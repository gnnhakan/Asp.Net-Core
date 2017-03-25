using MyCompany.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
