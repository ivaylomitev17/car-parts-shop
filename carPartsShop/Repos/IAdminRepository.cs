using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carPartsShop.Repos
{
   public  interface IAdminRepository<T>:IGenericRepository<T> where T : class
    {
        // public List<T> GetAllUsers();
        //public IQueryable GetAllUsers();
        public void ChangeUserRole(object UserId,object RoleId);
    }
}
