#pragma checksum "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\BlogByCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "961f7f43726919c14a6652325b59cab2c4af51ec"
// <auto-generated/>
#pragma warning disable 1591
namespace AQBlog.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/{Category}/{Page:int?}")]
    public partial class BlogByCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BlogByCategory</h3>\r\n\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 4 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\BlogByCategory.razor"
     Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "h1");
            __builder.AddContent(5, 
#nullable restore
#line 5 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\BlogByCategory.razor"
     Page

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\BlogByCategory.razor"
       
    [Parameter]
    public String Category { get; set; }

    [Parameter]
    public Int32 Page { get; set; } = 1;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
