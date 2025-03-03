using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WarehouseAPI.Models
{
    public class ProductsInventory
    {
        [Key]
        public int ProductsInventoryID { get; set; }
        [ForeignKey("Inventory")]
        [Column("InventoryID")]
        [MaybeNull]
        public int? InventoryID { get; set; }
        [ForeignKey("Products")]
        [Column("ProductID")]
        [MaybeNull]
        public int ProductID { get; set; }
        public int ActualQuantity { get; set; }
        public int AccountingQuantity { get; set;}
    }
}
