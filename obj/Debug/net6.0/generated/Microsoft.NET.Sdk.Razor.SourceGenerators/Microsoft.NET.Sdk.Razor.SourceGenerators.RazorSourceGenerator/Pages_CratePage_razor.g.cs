﻿#pragma checksum "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\Pages\CratePage.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "535b401ff4361432497421446f2135a1ba5a5283651719d32e1631b94aa3e1b4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTreeView.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\_Imports.razor"
using BlazorTreeView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\_Imports.razor"
using BlazorTreeView.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\Pages\CratePage.razor"
using BlazorTreeView.Shared.Models.Devices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\Pages\CratePage.razor"
using BlazorTreeView.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\Pages\CratePage.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Crate")]
    public partial class CratePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CratePage</h3>\r\n\r\n<div class=\"card\"></div>\r\n\t");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\Pages\CratePage.razor"
                         deviceHierarchyService.SelectedDevice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group mb-3");
                __builder2.AddMarkupContent(8, "<label for=\"MyInputText\">Название</label>\r\n\t\t\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "id", "MyInputText");
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\Pages\CratePage.razor"
                                       deviceHierarchyService.SelectedDevice.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => deviceHierarchyService.SelectedDevice.Name = __value, deviceHierarchyService.SelectedDevice.Name))));
                __builder2.AddAttribute(14, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => deviceHierarchyService.SelectedDevice.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group mb-3");
                __builder2.AddMarkupContent(18, "<label for=\"MyInputNumber1\">Номер (integer)</label>\r\n\t\t\t\t");
                __Blazor.BlazorTreeView.Pages.CratePage.TypeInference.CreateInputNumber_0(__builder2, 19, 20, "MyInputNumber1", 21, "form-control", 22, "Введите целочисленное значение", 23, 
#nullable restore
#line 24 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\Pages\CratePage.razor"
                                           ((Create)deviceHierarchyService.SelectedDevice).Number

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ((Create)deviceHierarchyService.SelectedDevice).Number = __value, ((Create)deviceHierarchyService.SelectedDevice).Number)), 25, () => ((Create)deviceHierarchyService.SelectedDevice).Number);
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n<hr>\r\n\r\n");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\Pages\CratePage.razor"
                                          SaveToDbClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "Сохранить");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\NikitinIlya\source\repos\BlazorTreeView\BlazorTreeView\Pages\CratePage.razor"
 
    private void SaveToDbClick()
    {
        deviceHierarchyRequestServicecs.SendHyerarchyAsync(deviceHierarchyService.Devices);
        notifyService.NotifyHierarchyChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotifyerService notifyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DeviceHierarchyService deviceHierarchyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DeviceHierarchyRequestServicecs deviceHierarchyRequestServicecs { get; set; }
    }
}
namespace __Blazor.BlazorTreeView.Pages.CratePage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "ParsingErrorMessage", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
