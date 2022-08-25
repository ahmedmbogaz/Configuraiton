using Core.DataAccess;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfProductBasketDal : EfEntityRepositoryBase<ProductBasket, DataBaseContext>, IProductBasketDal
    {
        public List<CityAnalysisDto> GetAllDetail()
        {
            using (DataBaseContext context=new())
            {
                var result = from p in context.ProductBaskets
                             join b in context.Baskets on p.BasketId equals b.BasketId
                             join c in context.Customers on b.CustomerId equals c.CustomerId
                             select new CityAnalysisDto()
                             {
                                  City=c.City,
                                  TotalPrice=p.Price,
                                  BasketPiece=b.BasketId
                             };
                return result.ToList();
            }
        }
    }
}
