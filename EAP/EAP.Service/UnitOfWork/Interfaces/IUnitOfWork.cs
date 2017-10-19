using EAP.Service.Repositories.Interfaces;

namespace EAP.Service.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IProductRepository Products { get; }
        IOrdersRepository Orders { get; }


        int SaveChanges();
    }
}