using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class OrderAddDto:IDto
    {
        public DateTime CreatedDate { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        //şipariş eklemek için prodcutId ve CustomerId ye ulaşmak yeterlidir.
    }
}
