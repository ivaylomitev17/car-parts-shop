using carPartsShop.Data;
using carPartsShop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carPartsShop.Repos
{
    public class AdminRepository : GenericRepository<UserRoleData>, IAdminRepository<UserRoleData> 
    {
        private ApplicationDbContext _context;
        
        public AdminRepository(ApplicationDbContext context) : base(context)
        {
           
            
            _context = context;

        }

        public void ChangeUserRole(object UserId,object RoleId)
        {
            throw new NotImplementedException();
        }

        public List<UserRoleData> GetAllUsers()
        {

            using (_context)
            {
                List<UserRoleData> ListAll = new List<UserRoleData>();
                var users = _context.Users;
                var roles = _context.Roles;
                var userRoles = _context.UserRoles;


                var query = from ur in userRoles
                            join u in users on ur.UserId equals u.Id
                            join r in roles on ur.RoleId equals r.Id
                            select new
                            {

                                UserName = u.UserName,
                                RoleName = r.Name

                            };

                ListAll = query.ToList;

                return ListAll;

            }

        } 
    }
}
