using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAP.Core.Repositories;
using EAP.Model;
using EAP.Model.Models;
using EAP.Service.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EAP.Service.Repositories
{
    class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(EAPContext context) : base(context)
        { }


        public IEnumerable<Customer> GetTopActiveCustomers(int count)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Customer> GetAllCustomersData()
        {
            return appContext.Customers
                .Include(c => c.Orders).ThenInclude(o => o.OrderDetails).ThenInclude(d => d.Product)
                .Include(c => c.Orders).ThenInclude(o => o.Cashier)
                .OrderBy(c => c.Name)
                .ToList();
        }



        private EAPContext appContext
        {
            get { return (EAPContext)_context; }
        }
    }
}
