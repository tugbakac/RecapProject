using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDTO : IDTO
    {
        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarColor { get; set; }
        public short DailyPrice { get; set; }
    }
}
