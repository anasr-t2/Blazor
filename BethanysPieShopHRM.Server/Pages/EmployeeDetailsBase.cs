using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using BethanysPieShopHRM.Server.Services;
using BethanysPieShopHRM.ComponentsLibrary.Map;

namespace BethanysPieShopHRM.Server.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        [Parameter]
        public int EmployeeId { get; set; }
        
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employee { get; set; }

        public bool Done { get; set; }

        public List<Marker> Markers { get; set; } = new List<Marker>();

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployeeDetails(EmployeeId);
            Markers.Add(new Marker { Description=$"{Employee.FirstName} {Employee.LastName} Location", ShowPopup=true, X=Employee.Longitude,Y = Employee.Latitude });
            Done = true;
        }
    }
}
