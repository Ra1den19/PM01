using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WarehouseAPI.Models
{
    public class ProductExpenditureInvoices
    {
        [Key]
        public int ProductsExpenditureInvoiceID { get; set; }
        [ForeignKey("ExpenditureInvoices")]
        [Column("ExpenditureInvoiceID")]
        [MaybeNull]
        public int? ExpenditureInvoiceID { get; set;}
        public int ProductID { get; set;}
        public int Quantity { get; set;}
        public string Price { get; set;}
    }
}
