#pragma checksum "c:\users\ankit\source\repos\BlazorCrud\BlazorCrud\BlazorCrud.Client\Pages\DeleteEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e373c4c831580e6ff591bb63b11c8bf257843c5c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using BlazorCrud.Client;
    using BlazorCrud.Client.Shared;
    using BlazorCrud.Shared.Models;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/delete/{empID}")]
    public class DeleteEmployee : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddContent(0, "\n");
            builder.OpenElement(1, "h2");
            builder.AddContent(2, "Delete");
            builder.CloseElement();
            builder.AddContent(3, "\n");
            builder.OpenElement(4, "h3");
            builder.AddContent(5, "Are you sure you want to delete employee with id : ");
            builder.AddContent(6, empID);
            builder.CloseElement();
            builder.AddContent(7, "\n\n");
            builder.OpenElement(8, "div");
            builder.AddContent(9, "\n    ");
            builder.OpenElement(10, "hr");
            builder.CloseElement();
            builder.AddContent(11, "\n    ");
            builder.OpenElement(12, "dl");
            builder.AddAttribute(13, "class", "dl-horizontal");
            builder.AddContent(14, "\n        ");
            builder.OpenElement(15, "dt");
            builder.AddContent(16, "Name");
            builder.CloseElement();
            builder.AddContent(17, "\n        ");
            builder.OpenElement(18, "dd");
            builder.AddContent(19, emp.Name);
            builder.CloseElement();
            builder.AddContent(20, "\n\n        ");
            builder.OpenElement(21, "dt");
            builder.AddContent(22, "Gender");
            builder.CloseElement();
            builder.AddContent(23, "\n        ");
            builder.OpenElement(24, "dd");
            builder.AddContent(25, emp.Gender);
            builder.CloseElement();
            builder.AddContent(26, "\n\n        ");
            builder.OpenElement(27, "dt");
            builder.AddContent(28, "Department");
            builder.CloseElement();
            builder.AddContent(29, "\n        ");
            builder.OpenElement(30, "dd");
            builder.AddContent(31, emp.Department);
            builder.CloseElement();
            builder.AddContent(32, "\n\n        ");
            builder.OpenElement(33, "dt");
            builder.AddContent(34, "City");
            builder.CloseElement();
            builder.AddContent(35, "\n        ");
            builder.OpenElement(36, "dd");
            builder.AddContent(37, emp.City);
            builder.CloseElement();
            builder.AddContent(38, "\n    ");
            builder.CloseElement();
            builder.AddContent(39, "\n\n    ");
            builder.OpenElement(40, "div");
            builder.AddAttribute(41, "class", "form-group");
            builder.AddContent(42, "\n        ");
            builder.OpenElement(43, "input");
            builder.AddAttribute(44, "type", "submit");
            builder.AddAttribute(45, "value", "Delete");
            builder.AddAttribute(46, "class", "btn btn-default");
            builder.AddAttribute(47, onclick(async () => await Delete()));
            builder.CloseElement();
            builder.AddContent(48, "\n        ");
            builder.OpenElement(49, "input");
            builder.AddAttribute(50, "type", "submit");
            builder.AddAttribute(51, "value", "Cancel");
            builder.AddAttribute(52, "class", "btn");
            builder.AddAttribute(53, onclick(cancel));
            builder.CloseElement();
            builder.AddContent(54, "\n    ");
            builder.CloseElement();
            builder.AddContent(55, "\n");
            builder.CloseElement();
            builder.AddContent(56, "\n\n");
        }
        #pragma warning restore 1998
        

public string empID { get; set; }

Employee emp = new Employee();

protected override async Task OnInitAsync()
{
    emp = await Http.GetJsonAsync<Employee>
    ("/api/Employee/Details/" + Convert.ToInt32(empID));
}

protected async Task Delete()
{
    await Http.DeleteAsync("api/Employee/Delete/" + Convert.ToInt32(empID));
    UriHelper.NavigateTo("/fetchemployee");
}

void cancel()
{
    UriHelper.NavigateTo("/fetchemployee");
}

        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
