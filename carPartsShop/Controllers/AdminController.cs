using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using carPartsShop.Data;
using carPartsShop.Repos;
using carPartsShop.ViewModels;
using CarPartsShopServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace carPartsShop.Controllers
{
    
    public class AdminController : Controller
    {


        private readonly IAdminRepository<UserRoleData> _content;

        public AdminController (IAdminRepository<UserRoleData> content)
        {
            _content = content;
        }



        public  IActionResult Index()
        {
            IQueryable query = _content.GetAllUsers();

            return View(query.);
        }


    }
}