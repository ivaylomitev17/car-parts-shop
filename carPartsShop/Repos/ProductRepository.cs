using carPartsShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carPartsShop.Repos
{
    public class ProductRepository<T> : GenericRepository<T>, IProductRepository<T> where T : class
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public List<T> GetByCategory(object CategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
