#pragma checksum "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611961fba7ee74ff102e689112f5efdb74dcfd05"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.Server.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.Server.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
    public partial class AddEmployeeDialog : AddEmployeeDialogBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
 if (ShowDialog)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show d-block");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "role", "document");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<h5 class=\"modal-title\" id=\"titleLabel\">Employee Quick Add</h5>\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "close");
            __builder.AddAttribute(21, "data-dismiss", "modal");
            __builder.AddAttribute(22, "aria-label", "Close");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                                                           Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "modal-body");
            __builder.AddMarkupContent(30, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(31);
            __builder.AddAttribute(32, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                      Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(36);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(38);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n\r\n                        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __builder2.AddMarkupContent(43, "<label for=\"firstName\">First name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "firstName");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "placeholder", "Enter first name");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                                         Employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog.TypeInference.CreateValidationMessage_0(__builder2, 52, 53, 
#nullable restore
#line 24 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                      () => Employee.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n                        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n                            ");
                __builder2.AddMarkupContent(59, "<label for=\"lastName\">Last name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "id", "lastName");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "placeholder", "Enter last name");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                                        Employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                            ");
                __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog.TypeInference.CreateValidationMessage_1(__builder2, 68, 69, 
#nullable restore
#line 30 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                      () => Employee.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(70, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n                        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "\r\n                            ");
                __builder2.AddMarkupContent(75, "<label for=\"email\">Email: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "id", "email");
                __builder2.AddAttribute(78, "class", "form-control");
                __builder2.AddAttribute(79, "placeholder", "Enter email");
                __builder2.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                                     Employee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Email = __value, Employee.Email))));
                __builder2.AddAttribute(82, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                            ");
                __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog.TypeInference.CreateValidationMessage_2(__builder2, 84, 85, 
#nullable restore
#line 36 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                      () => Employee.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(86, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group row");
                __builder2.AddMarkupContent(90, "\r\n                            ");
                __builder2.AddMarkupContent(91, "<label for=\"birthdate\">Birthdate: </label>\r\n                            ");
                __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog.TypeInference.CreateInputDate_3(__builder2, 92, 93, "birthdate", 94, "form-control ", 95, "Enter birthdate", 96, 
#nullable restore
#line 40 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                                          Employee.BirthDate

#line default
#line hidden
#nullable disable
                , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.BirthDate = __value, Employee.BirthDate)), 98, () => Employee.BirthDate);
                __builder2.AddMarkupContent(99, "\r\n                            ");
                __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog.TypeInference.CreateValidationMessage_4(__builder2, 100, 101, 
#nullable restore
#line 41 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                    () => Employee.BirthDate

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(102, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n                        ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group row");
                __builder2.AddMarkupContent(106, "\r\n                            ");
                __builder2.AddMarkupContent(107, "<label for=\"joinDate\">Join Date: </label>\r\n                            ");
                __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog.TypeInference.CreateInputDate_5(__builder2, 108, 109, "joinDate", 110, "joinDate", 111, "form-control", 112, "Enter Join Date", 113, 
#nullable restore
#line 46 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                                                        Employee.JoinedDate

#line default
#line hidden
#nullable disable
                , 114, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.JoinedDate = __value, Employee.JoinedDate)), 115, () => Employee.JoinedDate);
                __builder2.AddMarkupContent(116, "\r\n                            ");
                __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog.TypeInference.CreateValidationMessage_6(__builder2, 117, 118, 
#nullable restore
#line 47 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                    () => Employee.JoinedDate

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(119, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n                        ");
                __builder2.AddMarkupContent(121, "<button type=\"submit\" class=\"btn btn-primary\">Save employee</button>\r\n                        ");
                __builder2.OpenElement(122, "a");
                __builder2.AddAttribute(123, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                       Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(125, "Close");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(127, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n");
#nullable restore
#line 57 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "name", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "placeholder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
