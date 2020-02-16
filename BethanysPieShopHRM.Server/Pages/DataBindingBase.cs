using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Pages
{
    public class DataBindingBase:ComponentBase
    {
        public Employee Employee { get; set; }

        protected override Task OnInitializedAsync()
        {
            Employee = new Employee
            {
                FirstName = "Hamada",
                LastName = "zaabola"
            };

            return base.OnInitializedAsync();
        }

        public void ChangeEmpFirstName(string name)
        {
            Employee.FirstName = name;
        }
    }
}
