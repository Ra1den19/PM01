using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WarehouseAPI.Models
{
    public class IncomingInvoices
    {
        [Key]
        public int IncomingInvoiceID { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime DateReceipt { get; set; }
        [ForeignKey("Suppliers")]
        [Column("SuppliersID")]
        [MaybeNull]
        public int? SupplierID { get; set; }
        public string ProductsList { get; set; }
        public string TotalAmount { get; set; }
    }
}
