using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using WCFTestSolution.Data;
using WCFTestSolution.Entities;

namespace WCFTestSolution.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ZzaService : IZzaService, IDisposable
    {
        readonly ZzaDbContext _context = new ZzaDbContext();

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void SubmitOrder(Order order)
        {
            _context.Orders.Add(order);
            order.OrderItems.ForEach(orderItem => _context.OrderItems.Add(orderItem));

            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}