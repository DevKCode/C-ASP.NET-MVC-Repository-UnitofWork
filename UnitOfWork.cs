using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Key_onBoarding.Models;

namespace Key_onBoarding.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _dbContext;

        public IRepository<Product> ProductRepository => new GenericRepository<Product>(_dbContext);
        public IRepository<Store> StoreRepository => new GenericRepository<Store>(_dbContext);
        public IRepository<Customer> CustomerRepository => new GenericRepository<Customer>(_dbContext);

        public UnitOfWork()
        {
            this._dbContext = new ApplicationDbContext();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void RejectChanges()
        {
            foreach (var entry in _dbContext.ChangeTracker.Entries().Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;


                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    case EntityState.Modified:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}