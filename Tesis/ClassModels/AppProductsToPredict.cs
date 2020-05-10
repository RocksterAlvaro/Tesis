using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tesis.ClassModels
{
    public class AppProductsToPredict
    {
        public string Id { get; set; }

        public string ProductName { get; set; }

        public int ProductCost { get; set; }

        public string StockInOutDate { get; set; }

        public int StockChange { get; set; }
    }
}
