using BethanysPieShopHRM.Server.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Components
{
    public class AddEmployeeDialogBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employee { get; set; } = new Employee();
        public bool ShowDialog { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallBack { get; set; }

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            Employee = new Employee();
        }

        public async Task HandleValidSubmit()
        {
            Employee.CountryId = 1;
            Employee.JobCategoryId = 1;
            var addedEmployee = await EmployeeService.AddEmployee(Employee);

            await CloseEventCallBack.InvokeAsync(true);

            Close();
        }
    }
}
