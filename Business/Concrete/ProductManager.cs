using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //public List<ProductDetailDto> GetProductDetails()
        //{
        //    var result = _productDal.GetAll();

        //    List<ProductDetailDto> products = new List<ProductDetailDto>();
        //    foreach (var product in result)
        //    {
        //        products.Add(new ProductDetailDto()
        //        {
        //            Name = product.Name,
        //            CustomerName = product.Orders.Select(x=>x.Customer.Name).FirstOrDefault(),
        //            OrderCreatedDate=product.Orders.Select(x=>x.CreatedDate).FirstOrDefault()
                        
        //        });
        //    }
            

        //}
    }
}
