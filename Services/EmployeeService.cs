using FirstBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FirstBlazorApp.Services
{
    public class EmployeeService:IEmployeeService
    {
    private readonly HttpClient httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task<IEnumerable<Employee>> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
