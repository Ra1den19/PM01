using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WarehouseAPI.Models
{
    public class ProductsIncomingInvoices
    {
        [Key]
        public int ProductsIncomingInvoiceID { get; set; }
        public int IncomingInvoiceID { get; set; }
        [ForeignKey("Products")]
        [Column("ProductID")]
        [MaybeNull]
        public int? ProductID { get; set; }
        public int Quantity { get; set;}
        public string Price { get; set; }
    }
}
