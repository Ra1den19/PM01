using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseLibrary
{
    public class WarehouseCalculator
    {
        public int GetTotalQuantity(List<Warehouses> warehouses, List<ProductsInWarehouses> productsInWarehouses)
        {
            return productsInWarehouses.Sum(p => p.Quantity);
        }

        public int GetTotalQuantity(List<ProductsInWarehouses> productsInWarehouses, int warehouseId)
        {
            return productsInWarehouses
                .Where(p => p.WarehouseID == warehouseId)
                .Sum(p => p.Quantity);
        }

        public decimal GetTotalCost(List<ProductsInWarehouses> productsInWarehouses, List<Product> products)
        {
            return (decimal)productsInWarehouses.Sum(piw =>
                products.FirstOrDefault(p => p.ProductID == piw.ProductID)?.UnitPrice * piw.Quantity ?? 0);
        }

        public decimal GetTotalCost(List<ProductsInWarehouses> productsInWarehouses, List<Product> products, int warehouseId)
        {
            return (decimal)productsInWarehouses
                .Where(p => p.WarehouseID == warehouseId)
                .Sum(piw => products.FirstOrDefault(p => p.ProductID == piw.ProductID)?.UnitPrice * piw.Quantity ?? 0);
        }

        public Dictionary<string, int> GetQuantityByCategory(List<ProductsInWarehouses> productsInWarehouses, List<Product> products)
        {
            return productsInWarehouses
                .GroupBy(piw => products.FirstOrDefault(p => p.ProductID == piw.ProductID)?.Category)
                .ToDictionary(g => g.Key, g => g.Sum(p => p.Quantity));
        }

        public Dictionary<string, int> GetQuantityByCategory(List<ProductsInWarehouses> productsInWarehouses, List<Product> products, int warehouseId)
        {
            return productsInWarehouses
                .Where(p => p.WarehouseID == warehouseId)
                .GroupBy(piw => products.FirstOrDefault(p => p.ProductID == piw.ProductID)?.Category)
                .ToDictionary(g => g.Key, g => g.Sum(p => p.Quantity));
        }
    }
}
