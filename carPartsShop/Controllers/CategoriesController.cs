using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using carPartsShop.Data;
using carPartsShop.Models;
using carPartsShop.Repos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace carPartsShop.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository<Category> _category;

        public CategoriesController(ICategoryRepository<Category> category)
        {
            _category = category;
        }
        public IActionResult Index()
        {
            return View(_category.GetAll());
        }


        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin, Employee")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _category.Insert(category);
                    _category.Save();
                    return RedirectToAction("Index");

                }
            }
            catch (DataException dataException)
            {
                //TODO
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(category);
        }

        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _category.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _category.Update(category);
                    _category.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var category = _category.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete (Category category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _category.Delete(category);
                    _category.Save();
                }
                catch (DbUpdateConcurrencyException)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

    }
}