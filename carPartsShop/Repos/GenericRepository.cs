using carPartsShop.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carPartsShop.Repos
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        private ApplicationDbContext _context;
        protected DbSet<T> table;

        public GenericRepository (ApplicationDbContext context)
        {
            _context = context;
            table = context.Set<T>();
        }
        
        public void Delete(T obj)
        {
            //T exists = table.Find(Id);
            table.Remove(obj); 
        }
        
        public T GetById(object Id)
        {
            return table.Find(Id);
        }
        public void Insert(T obj)
        {
            table.Add (obj);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Update(T obj)
        {

            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
