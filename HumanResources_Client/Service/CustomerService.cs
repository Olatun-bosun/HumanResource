using HumanResources_Client.Models;
using Newtonsoft.Json;

namespace HumanResources_Client.Service
{
    public class CustomerService
    {
        private readonly HttpClient _httpClient;
        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync()
        {
            var response = await _httpClient.GetAsync("/api/Customer/GetAllCustomers");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var customers = JsonConvert.DeserializeObject<IEnumerable<CustomerDTO>>(content);
                return customers;
            }

            return new List<CustomerDTO>();
        }
    }
}
