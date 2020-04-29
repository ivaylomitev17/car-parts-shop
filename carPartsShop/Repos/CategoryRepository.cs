using carPartsShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carPartsShop.Repos
{
    public class CategoryRepository<T>:GenericRepository<T>,ICategoryRepository<T> where T:class

    {
       public CategoryRepository(ApplicationDbContext context):base(context)
        {

        } 

        public List<T> GetAll()
        {
            return table.ToList();
        }

        //public void Update(int id)
        //{
        //    T categoryToUpdate = table.Find(id);
        //    if (TryUpdateModel(categoryToUpdate, "",
        //            new string[] { "LastName", "FirstMidName", "EnrollmentDate" }))
        //    {
        //        try
        //        {
        //            db.SaveChanges();
        //        }
        //        catch (DataException /* dex */)
        //        {
        //            //Log the error (uncomment dex variable name and add a line here to write a log.
        //            ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
        //        }
        //    }

        //}
    }
}
