using EAP.Core.Repositories;
using EAP.Model;
using EAP.Model.Models;
using EAP.Service.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EAP.Service.Repositories
{
    public class OrdersRepository : Repository<Order>, IOrdersRepository
    {
        public OrdersRepository(DbContext context) : base(context)
        { }




        private EAPContext appContext
        {
            get { return (EAPContext)_context; }
        }

    }
}