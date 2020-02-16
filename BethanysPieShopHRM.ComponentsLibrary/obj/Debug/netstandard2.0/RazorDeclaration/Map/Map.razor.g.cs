#pragma checksum "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e6bf4ede6b1be9414cb92714990c7c50ee5126"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BethanysPieShopHRM.ComponentsLibrary.Map
{
    #line hidden
    using System.Linq;
#line 1 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using System;

#line default
#line hidden
#line 2 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using System.Collections.Generic;

#line default
#line hidden
#line 3 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using System.Threading.Tasks;

#line default
#line hidden
#line 4 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#line 5 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
    public partial class Map : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 11 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
       

    string elementId = $"map-{Guid.NewGuid().ToString("D")}";
    
    [Parameter] 
    public double Zoom { get; set; }

    [Parameter] 
    public List<Marker> Markers { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync(
            "deliveryMap.showOrUpdate",
            elementId,
            Markers);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
