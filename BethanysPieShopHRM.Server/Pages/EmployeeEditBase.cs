using BethanysPieShopHRM.Server.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Pages
{
    public class EmployeeEditBase:ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public ICountryService CountryService { get; set; }

        [Inject]
        public IJobCategoryService JobCategoryService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        public IEnumerable<Country> Countries { get; set; } = new List<Country>();
        public IEnumerable<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

        public string SelectedCountryId { get; set; }
        public string SelectedJobCategoryId { get; set; }

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool saved;

        protected override async Task OnInitializedAsync()
        {
            Countries = await CountryService.GetAllCountries();
            JobCategories = await JobCategoryService.GetAllJobCategories();

            if (EmployeeId != 0)
            {
                Employee = await EmployeeService.GetEmployeeDetails(EmployeeId);

                SelectedCountryId = Employee.CountryId.ToString();
                SelectedJobCategoryId = Employee.JobCategoryId.ToString();
            }
        }

        protected async Task HandleValidSubmit()
        {
            Employee.CountryId = int.Parse(SelectedCountryId);
            Employee.JobCategoryId = int.Parse(SelectedJobCategoryId);

            if(Employee.EmployeeId == 0) {
                var addedEmployee = await EmployeeService.AddEmployee(Employee);
                if(addedEmployee != null)
                {
                    StatusClass = "alert-success";
                    Message = "New Employee added successfully";
                    saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong";
                    saved = false;
                }
            }
            else
            {
                await EmployeeService.UpdateEmployee(Employee);
                StatusClass = "alert-success";
                Message = "Employee updated successfully";
                saved = true;
            }
        }

        protected async Task DeleteEmployee()
        {
            await EmployeeService.DeleteEmployee(Employee.EmployeeId);
            saved = true;
            Message = "Employee deleted successfully";
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/employeeoverview");
        }

        //public void Hamada()
        //{
        //    var x = Employee.CountryId;
        //}
    }
}
