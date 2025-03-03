using Microsoft.EntityFrameworkCore;

namespace WarehouseAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Warehouses> Warehouses { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<IncomingInvoices> IncomingInvoices { get; set; }
        public DbSet<ExpenditureInvoices> ExpenditureInvoices { get; set; }
        public DbSet<ProductsIncomingInvoices> ProductsIncomingInvoices { get; set; }
        public DbSet<ProductExpenditureInvoices> ProductsExpenditureInvoices { get; set; }
        public DbSet<ProductsInventory> ProductsInventory { get; set; }
        public DbSet<ProductsInWarehouses> ProductsInWarehouses { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
