using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carPartsShop.Repos
{
    public interface IGenericRepository<T> where T : class
    {
       
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        void Save();


    }
}

