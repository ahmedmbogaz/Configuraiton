using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ProductBasket:IEntity
    {
        public int ProductBasketId { get; set; }
        public int BasketId { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
