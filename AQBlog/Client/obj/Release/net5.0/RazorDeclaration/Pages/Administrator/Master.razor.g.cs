// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 5 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\Master.razor"
using AQBlog.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/master")]
    public partial class Master : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Administrator\Master.razor"
       
    private string masterCode = ""; 
    private List<MasterDetailMetaData> master = new List<MasterDetailMetaData>();

    protected override async Task OnInitializedAsync()
    {
        var masterDetail = await masterService.GetMaster();
        master = masterDetail.ToList();

        if (master.Count > 0)
        {
            masterCode = master.First().MasterCode;
        }
    }

    private IEnumerable<MasterMetaData> pagedData;
    private MudTable<MasterMetaData> table;

    private int totalItems;
    private string searchString = null;

    private async Task<TableData<MasterMetaData>> GetMasterDetail(TableState state)
    {
        IEnumerable<MasterMetaData> data = await masterService.GetMasterByCode(masterCode);

        data = data.Where(ele =>
        {
            if (string.IsNullOrEmpty(searchString))
                return true;

            if (ele.Title.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{ele.Title}".Contains(searchString))
                return true;

            return false;
        }).ToArray();

        totalItems = data.Count();

        pagedData = data.Skip(state.Page * state.PageSize).Take(state.PageSize).ToArray();
        return new TableData<MasterMetaData>() { TotalItems = totalItems, Items = pagedData };
    }


    private void OnSearch(string text)
    {
        searchString = text;
        table.ReloadServerData();
    }

    private void Edit(MasterMetaData data)
    {
        navigationManager.NavigateTo("/auth/editmaster/" + data.Id);
    }


    private void AddMaster()
    {
        navigationManager.NavigateTo("/auth/addmaster");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMasterService masterService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
