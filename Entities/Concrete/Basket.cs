using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Basket:IEntity
    {
        public int BasketId { get; set; }
        public int CustomerId { get; set; }

    }
}
