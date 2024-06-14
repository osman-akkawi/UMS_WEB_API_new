using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UMS_DAL.Models;

namespace UMS_DAL.Repositories._GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class //not gonna do dependency injection bcz
                                                                              //im not gonna create object (new generic)
    {
        public readonly DbSet<T> _dbSet;
        public readonly UmsContext _umsContext; //if i want to use major,i call by umscontext not
                                                //dbset bcz dbset i wrote only for faculties
        public GenericRepository(UmsContext umsContext)
        {
            _umsContext = umsContext;
            _dbSet = umsContext.Set<T>();
        }
        public T Add(T entity)
        {
            var result = _dbSet.Add(entity);//posso tirar o var result =
            _umsContext.SaveChanges(); //save i always do for the original context
            return entity; // i can write result.Entity
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }


        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public T Update(T faculty)
        {
            _dbSet.Update(faculty);
            try
            {
                _umsContext.SaveChanges();
                ;
            }
            catch (Exception ex) { }
            return faculty;
        }

        public bool Delete(T faculty)
        {
            _dbSet.Remove(faculty);
            try
            {
                _umsContext.SaveChanges();
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
