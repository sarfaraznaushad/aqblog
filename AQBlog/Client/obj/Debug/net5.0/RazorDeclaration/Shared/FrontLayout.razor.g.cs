// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AQBlog.Client.Shared
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
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using AQBlog.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using AQBlog.Client.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using AQBlog.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using AQBlog.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using AQBlog.Client.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
using AQBlog.Shared;

#line default
#line hidden
#nullable disable
    public partial class FrontLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
       
    private bool resetValueOnEmptyText;
    private string value2;

    private ThemeManagerTheme _themeManager = new ThemeManagerTheme();


    void UpdateTheme(ThemeManagerTheme value)
    {
        _themeManager = value;
        StateHasChanged();
    }

    protected override void OnInitialized()
    {
        _themeManager.Theme = new MudBlazorAdminDashboard();
        _themeManager.DrawerClipMode = DrawerClipMode.Always;
        _themeManager.FontFamily = "Montserrat";
        _themeManager.DefaultBorderRadius = 3;
        _themeManager.AppBarElevation = 0;
        _themeManager.DrawerElevation = 25;

        StateHasChanged();
    }

    private List<BreadcrumbItem> _items = new List<BreadcrumbItem>
{
        new BreadcrumbItem("Dashboard", href: "#"),
    };

    private void OnValueChanged(string val)
    {
        //this.AppState.SetVal(val);
        navigationManager.NavigateTo("/" + val.Replace(' ','-'));
    }



    private async Task<IEnumerable<string>> AutoComplete(string value)
    {
        // if text is null or empty, don't return values (drop-down will not open)
        if (string.IsNullOrEmpty(value))
            return new string[0];

        await Task.Delay(2000);
        var titles = await frontService.SearchBlog(value);

        return titles;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFrontService frontService { get; set; }
    }
}
#pragma warning restore 1591
