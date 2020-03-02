using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tesis.ClassModels
{
    public class StockInOut
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public string StockInOutDate { get; set; }

        public string InOrOut { get; set; }

        public string StockOrSale { get; set; }

        public int TotalPrice { get; set; }

        public int ClientCC { get; set; }
    }
}
