using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Key_onBoarding.Models;

namespace Key_onBoarding.DAL
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<Product> ProductRepository { get; }
        IRepository<Store> StoreRepository { get; }
        IRepository<Customer> CustomerRepository { get; }

        void Commit();
        void RejectChanges();


    }

}