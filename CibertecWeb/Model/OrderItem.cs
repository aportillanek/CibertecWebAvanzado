using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibertecWeb.Model
{
    public class OrderItem
    {
        public int Id { get; set; }
        public virtual Order OrderId { get; set; }
      //  public virtual Product ProductId { get; set; }
        public string City { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
