using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseLibrary
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Article { get; set; }
        public string Barcode { get; set; }
        public string Category { get; set; }
        public string UnitOfMeasurement { get; set; }
        public double UnitPrice { get; set; }
        public int SerialNumber { get; set; }
        public int MinBalance { get; set; }
        public int WarehouseId { get; set; }
    }
}
