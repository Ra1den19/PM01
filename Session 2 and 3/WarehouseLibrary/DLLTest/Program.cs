using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using WarehouseLibrary;
using System.Text.Json;

namespace DLLTest
{
    public class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task Main(string[] args)
        {
            string apiBaseUrl = "https://localhost:7033/";

            var warehouses = await GetDataFromApi<List<Warehouses>>($"{apiBaseUrl}warehouses");
            var products = await GetDataFromApi<List<Product>>($"{apiBaseUrl}products");
            var productsInWarehouses = await GetDataFromApi<List<ProductsInWarehouses>>($"{apiBaseUrl}productsinwarehouses");

            var calculator = new WarehouseCalculator();

            int totalQuantity = calculator.GetTotalQuantity(warehouses, productsInWarehouses);
            Console.WriteLine($"Total quantity of products in all warehouses: {totalQuantity}");

            int totalQuantityWarehouse1 = calculator.GetTotalQuantity(productsInWarehouses, 1);
            Console.WriteLine($"Total quantity of products in Warehouse A: {totalQuantityWarehouse1}");

            decimal totalCost = calculator.GetTotalCost(productsInWarehouses, products);
            Console.WriteLine($"Total cost of products in all warehouses: {totalCost}");

            decimal totalCostWarehouse1 = calculator.GetTotalCost(productsInWarehouses, products, 1);
            Console.WriteLine($"Total cost of products in Warehouse A: {totalCostWarehouse1}");

            var quantityByCategory = calculator.GetQuantityByCategory(productsInWarehouses, products);
            Console.WriteLine("Quantity of products by category in all warehouses:");
            foreach (var category in quantityByCategory)
            {
                Console.WriteLine($"{category.Key}: {category.Value}");
            }

            var quantityByCategoryWarehouse1 = calculator.GetQuantityByCategory(productsInWarehouses, products, 1);
            Console.WriteLine("Quantity of products by category in Warehouse A:");
            foreach (var category in quantityByCategoryWarehouse1)
            {
                Console.WriteLine($"{category.Key}: {category.Value}");
            }
        }

        private static async Task<T> GetDataFromApi<T>(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseData = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseData);
        }
    }
}
