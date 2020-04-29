using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carPartsShop.Repos
{
    public interface ICategoryRepository<T>:IGenericRepository<T> where T:class
    {
        List<T> GetAll();

        //void Update(int id);
    }


}
