using Microsoft.EntityFrameworkCore;
using SafejoApplicationForm.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafejoApplicationForm.Repository.Respository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _db = _context.Set<T>();
        }
        /// <summary>
        /// add the object to the database
        /// </summary>
        /// <param name="entity"></param>
        public void InsertAysnc(T entity)
        {
            try
            {
                _db.AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// update the instance in the database athat has Id
        /// </summary>
        /// <param name="item"></param>
        public void Update(T item)
        {
            try
            {
                _db.Attach(item);
                _context.Entry(item).State = EntityState.Modified;
            }
            catch (Exception)
            {
                throw;   
            }
        }
        /// <summary>
        ///  removes the object from the db context
        /// </summary>
        /// <param name="id"></param>
        public async void DeleteAsync(string id)
        {
            try
            {
                _db.Remove(await _db.FindAsync(id));
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// removes a list a object from the databsea
        /// </summary>
        /// <param name="entities"></param>
       public void DeleteRangeAsync (IEnumerable<T> entities)
        {
             _db.RemoveRange(entities);
        }
    }
}
