using Business.Abstract;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<OrderDetailDto> OrderDetails()
        {
            var orders = _orderDal.GetAllOrders();

            List<OrderDetailDto> orderDetails = new List<OrderDetailDto>();
            foreach (var item in orders)
            {
                orderDetails.Add(new OrderDetailDto()
                {
                    CreatedDate= DateTime.Now,
                    CustomerName=item.Customer.Name
                });
            }
            return orderDetails;
        }
    }
}
