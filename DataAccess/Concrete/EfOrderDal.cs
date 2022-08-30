using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NewContext>, IOrderDal
    {
        public List<Order> GetAllOrders()
        {
            using (var context=new NewContext())
            {
                var result = context.Orders.Include(x => x.Customer);
                return result.ToList();
            }
        }
    }
}
