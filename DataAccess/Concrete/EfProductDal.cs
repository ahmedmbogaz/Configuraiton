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
    public class EfProductDal : EfEntityRepositoryBase<Product, NewContext>, IProductDal
    {
        public List<Product> GetAllProducts()
        {
            using (var context=new NewContext())
            {
                var result = context.Products.Include(x => x.Orders).ThenInclude(x=>x.Customer);
                return result.ToList();
            }
        }
    }
}
