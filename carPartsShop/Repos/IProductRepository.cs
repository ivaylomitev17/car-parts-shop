using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carPartsShop.Repos
{
    interface IProductRepository<T>:IGenericRepository<T> where T:class
    {
        public List<T> GetByCategory(object CategoryId);
    }
}
