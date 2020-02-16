﻿using BethanysPieShopHRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>(
                await _httpClient.GetStreamAsync($"api/employee"),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            return await JsonSerializer.DeserializeAsync<Employee>(
                await _httpClient.GetStreamAsync($"api/employee/{employeeId}"),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var employeeJson = JsonSerializer.Serialize(employee);
            var employeeContent = new StringContent(employeeJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Employee", employeeContent);

            if (response.IsSuccessStatusCode)
            {
                var addedEmployee = await JsonSerializer.DeserializeAsync<Employee>(await response.Content.ReadAsStreamAsync());
                return addedEmployee;
            }

            return null;
        }

        public async Task UpdateEmployee(Employee employee)
        {
            var employeeJson = JsonSerializer.Serialize(employee);
            var employeeContent = new StringContent(employeeJson, Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/Employee", employeeContent);
        }

        public async Task DeleteEmployee(int employeeId)
        {
            await _httpClient.DeleteAsync($"api/Employee/{employeeId}");
        }
    }
}