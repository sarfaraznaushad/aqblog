// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 10 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Index.razor"
using AQBlog.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{page:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{page:int}/{q}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{q}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/{categoryid}/{category}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/{categoryid}/{category}/{page:int}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Index.razor"
      
    private List<BlogFrontDetailMetaData> blogs;
    [Parameter]
    public int page { get; set; }

    [Parameter]
    public string q { get; set; }

    [Parameter]
    public string category { get; set; }

    [Parameter]
    public string categoryid { get; set; }

    PageInfo pagingInfo = new PageInfo();
    BlogDetailPagingMetaData blogReq = new BlogDetailPagingMetaData();

    //protected async override void OnInitialized()
    //{
    //    await CreatePagingInfo();
    //    navigationManager.LocationChanged += NavigationManager_LocationChanged;
    //}

    //private async void NavigationManager_LocationChanged(object sender, LocationChangedEventArgs e)
    //{
    //    var url = e.Location;
    //    page = 0;
    //    await CreatePagingInfo();

    //    // Parse URL for query string here
    //}

    protected override async Task OnParametersSetAsync()
    {
        await CreatePagingInfo();
    }

    private async Task CreatePagingInfo()
    {
        int PageSize = 1;

        // var q = navigationManager.QueryString("q");
        blogReq = new BlogDetailPagingMetaData();
        blogReq.PageNo = page > 0 ? (page - 1) : page;
        blogReq.Search = q == null ? "" : q;
        blogReq.PageSize = PageSize;
        blogReq.CategoryId = categoryid;

        var blogDetails = await frontService.GetBlogs(blogReq);

        pagingInfo = new PageInfo();
        page = page == 0 ? 1 : page;
        pagingInfo.CurrentPage = page;
        pagingInfo.TotalItems = blogDetails.TotalRecord;
        pagingInfo.ItemsPerPage = PageSize;

        blogs = blogDetails.Blogs;

        StateHasChanged();
    }

    //void IDisposable.Dispose() => navigationManager.LocationChanged -= NavigationManager_LocationChanged;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFrontService frontService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
