using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WHApp
{
    public partial class AddWarehouseForm : Form
    {
        private readonly HttpClient _httpClient;
        public AddWarehouseForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async Task AddWarehouseAsync(Warehouses warehouse)
        {
            try
            {
                string url = "https://localhost:7033/api/Warehouses"; // URL API для добавления склада

                // Отправляем POST-запрос с данными склада
                var response = await _httpClient.PostAsJsonAsync(url, warehouse);

                // Проверяем, успешен ли запрос
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Склад успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Ошибка при добавлении склада: {errorMessage}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении склада: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            var warehouse = new Warehouses
            {
                Name = textName.Text,
                Address = textAddress.Text,
                Type = textType.Text,
                StorageArea = textArea.Text,
            };

            await AddWarehouseAsync(warehouse);
            Close();

        }
    }

    public class Warehouses
    {
        public int WarehouseID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string StorageArea { get; set; }
    }
}
