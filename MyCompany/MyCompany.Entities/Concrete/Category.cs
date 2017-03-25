using MyCompany.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Entities.Concrete
{
    public class Category: IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
