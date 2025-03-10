using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ddos_test
{
    public class Warehouses
    {
        public int WarehouseID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string StorageArea { get; set; }
    }

    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "https://localhost:7033/api/Warehouses"; // Замените на ваш URL

        static async Task Main(string[] args)
        {
            int numberOfRequests = 1000; // Количество запросов для тестирования

            var warehouseData = new Warehouses
            {
                WarehouseID = 0, // Пример ID, замените на нужное значение
                Name = "Main Warehouse",
                Address = "123 Warehouse St", // Пример адреса, замените на нужное значение
                Type = "Distribution", // Пример типа, замените на нужное значение
                StorageArea = "5000 sq ft" // Пример площади хранения, замените на нужное значение
            };

            await LoadTestWarehouseCreation(numberOfRequests, warehouseData);
        }

        private static async Task LoadTestWarehouseCreation(int numberOfRequests, Warehouses warehouseData)
        {
            Console.WriteLine($"Starting load test for Warehouse creation with {numberOfRequests} requests...");
            var tasks = new Task[numberOfRequests];

            for (int i = 0; i < numberOfRequests; i++)
            {
                tasks[i] = CreateWarehouseAsync(warehouseData);
            }

            await Task.WhenAll(tasks);
            Console.WriteLine("Load test for Warehouse creation completed.");
        }

        private static async Task CreateWarehouseAsync(Warehouses warehouseData)
        {
            var json = JsonSerializer.Serialize(warehouseData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(BaseUrl, content); // Используем базовый URL для POST-запроса
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Warehouse creation successful.");
            }
            else
            {
                Console.WriteLine("Warehouse creation failed: " + await response.Content.ReadAsStringAsync());
            }
        }
    }
}
