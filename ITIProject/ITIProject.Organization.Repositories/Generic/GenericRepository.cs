using ITIProject.Organization.Entities;
using ITIProject.Organization.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.Repositories
{
    public class GenericRepository<T> where T : BaseModel
    {
        private DbSet<T> dbSet;
        public EntitiesContext Context { get; set; }
        public GenericRepository(EntitiesContext context)
        {
            Context = context;
            dbSet = Context.Set<T>();
        }

        public T Add(T T)
        {
            return dbSet.Add(T);
        }
        public T GetByID(int id)
        {

            return dbSet.FirstOrDefault(i => i.ID == id);
        }
        public T Update(T T)
        {
            if (!dbSet.Local.Any(i => i.ID == T.ID))
                dbSet.Attach(T);
            Context.Entry(T).State = EntityState.Modified;
            return T;


        }
        public void Remove(T T)
        {
            dbSet.Remove(T);
        }
        public IEnumerable<T> GetAllData()
        {
            return dbSet;
        }
        public IEnumerable<T> Get(Expression<Func<T, bool>> filter)
        {
            return dbSet.Where(filter);
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public object Get(Func<School, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
