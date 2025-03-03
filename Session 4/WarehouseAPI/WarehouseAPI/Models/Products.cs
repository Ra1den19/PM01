using System.ComponentModel.DataAnnotations;

namespace WarehouseAPI.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Article { get; set; }
        public string Barcode { get; set; }
        public string Category { get; set; }
        public string UnitOfMeasurement { get; set; }
        public double UnitPrice { get; set; }
        public int SerialNumber { get; set;}
        public int MinBalance { get; set; }
    }
}
