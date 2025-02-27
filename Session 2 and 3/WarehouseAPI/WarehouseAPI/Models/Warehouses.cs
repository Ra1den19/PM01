using System.ComponentModel.DataAnnotations;
namespace WarehouseAPI.Models
{
    public class Warehouses
    {
        [Key]
        public int WarehouseID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string StorageArea { get; set; }
    }
}
