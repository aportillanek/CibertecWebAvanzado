using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibertecWeb.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public virtual Customer Customer { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
