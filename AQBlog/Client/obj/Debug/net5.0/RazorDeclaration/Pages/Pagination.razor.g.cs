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
#line 1 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Pagination.razor"
using AQBlog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Pagination.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Pages\Pagination.razor"
       

    [Parameter]
    public PageInfo pageInfo { get; set; }

    [Parameter]
    public bool PageClassesEnabled { get; set; }

    [Parameter]
    public string PageClass { get; set; }

    [Parameter]
    public string PageClassSelected { get; set; }

    public string CreatePaging()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<div>");
        string anchorInnerHtml = "";

        for (int i = 1;i <= pageInfo.TotalPages; i++)
        {
            StringBuilder tag = new StringBuilder();
            tag.Append("<a ");

            anchorInnerHtml = AnchorInnerHtml(i, pageInfo);
            if (anchorInnerHtml == "..")
                tag.Append("href='#'");
            else if (i == 1)
                tag.Append("href='/'");
            else
                tag.Append("href='/"+i+"'");

           

            if (PageClassesEnabled)
            {

                if(pageInfo.CurrentPage == i)
                {
                    var str = $" class='{PageClass} {PageClassSelected}'";
                    tag.Append(str);
                }
                else
                {
                    tag.Append(" class='" + PageClass+"'");
                }
            }

            tag.Append($" >{i}</a>");
            sb.Append(tag.ToString());
        }

        sb.Append("</div>");
        var st = sb.ToString();
        return sb.ToString();
    }

    public static string AnchorInnerHtml(int i, PageInfo pagingInfo)
    {
        string anchorInnerHtml = "";
        if (pagingInfo.TotalPages <= 10)
            anchorInnerHtml = i.ToString();
        else
        {
            if (pagingInfo.CurrentPage <= 5)
            {
                if ((i <= 8) || (i == pagingInfo.TotalPages))
                    anchorInnerHtml = i.ToString();
                else if (i == pagingInfo.TotalPages - 1)
                    anchorInnerHtml = "..";
            }
            else if ((pagingInfo.CurrentPage > 5) && (pagingInfo.TotalPages - pagingInfo.CurrentPage >= 5))
            {
                if ((i == 1) || (i == pagingInfo.TotalPages) || ((pagingInfo.CurrentPage - i >= -3) && (pagingInfo.CurrentPage - i <= 3)))
                    anchorInnerHtml = i.ToString();
                else if ((i == pagingInfo.CurrentPage - 4) || (i == pagingInfo.CurrentPage + 4))
                    anchorInnerHtml = "..";
            }
            else if (pagingInfo.TotalPages - pagingInfo.CurrentPage < 5)
            {
                if ((i == 1) || (pagingInfo.TotalPages - i <= 7))
                    anchorInnerHtml = i.ToString();
                else if (pagingInfo.TotalPages - i == 8)
                    anchorInnerHtml = "..";
            }
        }
        return anchorInnerHtml;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
