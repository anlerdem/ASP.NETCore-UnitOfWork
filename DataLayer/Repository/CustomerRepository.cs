using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Repository.IRepository;
using ModelLayer;

namespace DataLayer.Repository
{
    internal class CustomerRepository:Repository<Customer>,ICustomerRepository
    {
        public readonly ApplicationDbContext Context;
        public CustomerRepository(ApplicationDbContext Context):base(Context)
        {
            this.Context = Context;
            
        }
    }
}
