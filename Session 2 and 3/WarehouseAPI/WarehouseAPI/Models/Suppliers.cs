using System.ComponentModel.DataAnnotations;

namespace WarehouseAPI.Models
{
    public class Suppliers
    {
        [Key]
        public int SupplierID { get; set; }
        public string Name { get; set;}
        public int INN { get; set;}
        public string ContactDetails { get; set;}
        public string Address { get; set;}
    }
}
