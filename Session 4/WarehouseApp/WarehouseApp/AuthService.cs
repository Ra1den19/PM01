using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace WarehouseApp
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7033/");
        }

        public async Task<string> LoginAsync(int employeeID, string firstname, string lastName, string login, string password, string email, string role)
        {
            var user = new
            {
                employeeID = employeeID,
                firstname = firstname,
                lastName = lastName,
                login = login,
                password = password,
                email = email,
                role = role
            };

            var response = await _httpClient.PostAsJsonAsync("api/auth/login", user);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return null; // Или обработка ошибки в зависимости от ваших требований
        }

        public async Task<string> GetUserRoleAsync(string email)
        {
            var response = await _httpClient.GetAsync($"login/Email?email={email}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return null; // Или обработка ошибки в зависимости от ваших требований
        }
    }
}
