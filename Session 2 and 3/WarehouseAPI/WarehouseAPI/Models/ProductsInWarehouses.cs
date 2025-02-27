using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WarehouseAPI.Models
{
    public class ProductsInWarehouses
    {
        [Key]
        public long ProductInWarehouseID { get; set; }
        [ForeignKey("Products")]
        [Column("ProductID")]
        [MaybeNull]
        public int? ProductID { get; set; }
        [ForeignKey("Warehouses")]
        [Column("WarehouseID")]
        [MaybeNull]
        public int? WarehouseID { get; set; }
        public int Quantity { get; set; }
        public Products? Product { get; set; }
    }
}
