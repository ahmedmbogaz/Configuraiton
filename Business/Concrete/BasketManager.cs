using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;
        ICustomerService _customerService;

        public BasketManager(IBasketDal basketDal, ICustomerService customerService)
        {
            _basketDal = basketDal;
            _customerService = customerService;
        }

        public IResult Add(Basket basket, Customer customer)
        {
            //basket.CustomerId

            Random rastgelesayi = new Random();
            var basket1=customer.CustomerId;
            int no = rastgelesayi.Next(0,basket1 );
            basket.CustomerId = no;


            _basketDal.Add(basket);
            return new SuccessResult(Messages.BasketAdded);
        }

        
    }
}
