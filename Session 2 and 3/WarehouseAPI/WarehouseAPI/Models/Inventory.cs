using System.ComponentModel.DataAnnotations;
namespace WarehouseAPI.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryID { get; set; }
        public DateTime DateEvent { get; set; }
        public int Responsible { get; set; }
        public int Results { get; set; }
    }
}
