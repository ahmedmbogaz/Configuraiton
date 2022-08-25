using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CityAnalysisDto:IDto
    {
        public string City { get; set; }
        public int BasketPiece{ get; set; }
        public float TotalPrice { get; set; }
    }
}
