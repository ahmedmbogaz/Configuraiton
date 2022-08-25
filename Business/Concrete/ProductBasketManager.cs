using Business.Abstract;
using Business.Constants;
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
    public class ProductBasketManager : IProductBasketService
    {
        IProductBasketDal _productBasketDal;

        public ProductBasketManager(IProductBasketDal productBasketDal)
        {
            _productBasketDal = productBasketDal;
        }

        public IResult Add(ProductBasket productBasket)
        {
            _productBasketDal.Add(productBasket);
            return new SuccessResult(Messages.ProductBasketAdded);
        }

        public IDataResult<List<CityAnalysisDto>> GetCityAnalysis()
        {
            _productBasketDal
        }

       
    }
}
