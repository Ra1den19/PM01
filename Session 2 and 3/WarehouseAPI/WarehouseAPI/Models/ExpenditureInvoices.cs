using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WarehouseAPI.Models
{
    public class ExpenditureInvoices
    {
        [Key]
        public int ExpenditureInvoiceID { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime ShippingDate { get; set;}
        [ForeignKey("Clients")]
        [Column("ClientID")]
        [MaybeNull]
        public int? ClientID { get; set; }
        public string ProductsList { get; set; }
        public string TotalAmount { get; set; }
    }
}
