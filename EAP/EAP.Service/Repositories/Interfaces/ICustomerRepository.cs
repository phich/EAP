using System.Collections.Generic;
using EAP.Core.Repositories.Interfaces;
using EAP.Model.Models;

namespace EAP.Service.Repositories.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetTopActiveCustomers(int count);
        IEnumerable<Customer> GetAllCustomersData();
    }
}