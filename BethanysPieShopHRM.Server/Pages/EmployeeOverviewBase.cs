using BethanysPieShopHRM.Server.Components;
using BethanysPieShopHRM.Server.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Pages
{
    public class EmployeeOverviewBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        public AddEmployeeDialog QuickAddEmployeeDialog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeService.GetAllEmployees();
        }

        protected void QuickAddEmployee()
        {
            QuickAddEmployeeDialog.Show();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = await EmployeeService.GetAllEmployees();
            StateHasChanged();
        }
    }
}
