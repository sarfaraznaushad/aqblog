#pragma checksum "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\AddBlog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d7c41b363587a6965d9c774a76379b603d76b20"
// <auto-generated/>
#pragma warning disable 1591
namespace AQBlog.Client.Pages.Administrator
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using AQBlog.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using AQBlog.Client.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using AQBlog.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/addblog")]
    public partial class AddBlog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddBlog</h3>\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudTextField<string>>(1);
            __builder.AddAttribute(2, "Label", "Title");
            __builder.AddAttribute(3, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 6 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\AddBlog.razor"
                                                Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Class", "my-6");
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<MudBlazor.MudTextField<string>>(6);
            __builder.AddAttribute(7, "Label", "Subject");
            __builder.AddAttribute(8, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 7 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\AddBlog.razor"
                                                  Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Class", "my-6");
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenComponent<MudBlazor.MudTextField<string>>(11);
            __builder.AddAttribute(12, "Label", "Category");
            __builder.AddAttribute(13, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 8 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\AddBlog.razor"
                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Class", "my-6");
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenComponent<MudBlazor.MudTextField<string>>(16);
            __builder.AddAttribute(17, "Label", "Tags");
            __builder.AddAttribute(18, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 9 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\AddBlog.razor"
                                               Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "Class", "my-6");
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenComponent<MudBlazor.MudTextField<string>>(21);
            __builder.AddAttribute(22, "Label", "Description");
            __builder.AddAttribute(23, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 10 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\AddBlog.razor"
                                                      Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Class", "my-6");
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenComponent<MudBlazor.MudButton>(26);
            __builder.AddAttribute(27, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 11 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\AddBlog.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\AddBlog.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "Link", "/dashboard");
            __builder.AddAttribute(30, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 11 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\AddBlog.razor"
                                                                                  Size.Large

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\AddBlog.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "\r\n    Save\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
