using HumanResources_Client.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace HumanResources_Client.Service
{
    public class EmployeeService
    {
        private readonly HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }    
        public async Task<IEnumerable<EmployeeDTO>> GetAll()
        {
            var response = await _httpClient.GetAsync("/api/Employee");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var employees = JsonConvert.DeserializeObject<IEnumerable<EmployeeDTO>>(content);
                return employees;
            }

            return new List<EmployeeDTO>();
        }
    }
}
