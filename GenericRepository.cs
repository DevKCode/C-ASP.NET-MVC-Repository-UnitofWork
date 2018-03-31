using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using Key_onBoarding.Models;

namespace Key_onBoarding.DAL
{
    public class GenericRepository<T> : IRepository<T> where T: class
    {
        public ApplicationDbContext Context;
        public DbSet<T> DbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            this.Context = context;
            DbSet = Context.Set<T>();
        }
        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Edit(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;

        }
    }
}