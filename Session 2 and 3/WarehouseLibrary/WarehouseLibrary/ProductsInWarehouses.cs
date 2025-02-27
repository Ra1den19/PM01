using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseLibrary
{
    public class ProductsInWarehouses
    {
        public int ProductInWarehouseID { get; set; }
        public int ProductID { get; set; }
        public int WarehouseID { get; set; }
        public int Quantity { get; set; }
    }
}
