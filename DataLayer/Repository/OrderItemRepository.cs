using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Repository.IRepository;
using ModelLayer;

namespace DataLayer.Repository
{
    internal class OrderItemRepository:Repository<OrderItem>,IOrderItemRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderItemRepository(ApplicationDbContext context):base(context) 
        {
            _context = context;
        }
    }
}
