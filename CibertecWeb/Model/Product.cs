using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibertecWeb.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public virtual Supplier SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Package { get; set; }
        public string IsDiscontinued { get; set; }
    }
}
