using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Repository.IRepository;
using ModelLayer;

namespace DataLayer.Repository
{
    internal class OrderRepository:Repository<Order>,IOrderRepository
    {
        private ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context):base(context) 
        {
            _context = context;
        }
    }
}
