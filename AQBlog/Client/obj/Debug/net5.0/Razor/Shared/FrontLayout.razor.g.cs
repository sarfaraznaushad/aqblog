#pragma checksum "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dee812e38bc4461ecd17c76ad5a1dea25782e157"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class FrontLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 3 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                         _themeManager.Theme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(9);
                __builder2.AddAttribute(10, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                          _themeManager.AppBarElevation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(13, "div");
                    __builder3.OpenComponent<MudBlazor.MudLink>(14);
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudAvatar>(16);
                        __builder4.AddAttribute(17, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                    $"color:#ffffff; font-weight: 800;"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                                                                 Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "Square", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(21, "</>");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudAvatar>(23);
                        __builder4.AddAttribute(24, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                    $"color:#ffffff; font-weight: 800;"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                                                                 Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "Square", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(28, " AQ");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\r\n\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudAppBarSpacer>(30);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudAutocomplete<string>>(32);
                    __builder3.AddAttribute(33, "SearchFunc", new System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>>>(
#nullable restore
#line 18 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                                                      AutoComplete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "ResetValueOnEmptyText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                                 resetValueOnEmptyText

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 19 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                                                                 Variant.Outlined

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "AdornmentIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                         Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Margin>(
#nullable restore
#line 20 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                                                               Margin.Dense

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                  $"background:{Colors.Blue.Lighten1};"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 18 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                                 value2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value2 = __value, value2))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudAppBarSpacer>(42);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n   \r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(44);
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(46);
                    __builder3.AddAttribute(47, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 27 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                MaxWidth.False

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "Class", "mt-4");
                    __builder3.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudGrid>(50);
                        __builder4.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudItem>(52);
                            __builder5.AddAttribute(53, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(54, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                     9

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(55, "Class", "pr-4");
                            __builder5.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudPaper>(57);
                                __builder6.AddAttribute(58, "Class", "d-block align-start py-2 px-1");
                                __builder6.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(60, 
#nullable restore
#line 31 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                         Body

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(61, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudItem>(62);
                            __builder5.AddAttribute(63, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(64, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
                                     3

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudPaper>(66);
                                __builder6.AddAttribute(67, "Class", "d-block align-start py-2 px-1");
                                __builder6.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<AQBlog.Client.Pages.Category>(69);
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "F:\AlqubaTechBusiness\CRM\Blazor\aqblog\AQBlog\Client\Shared\FrontLayout.razor"
       
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

    private string[] states =
  {
        "Alabama", "Alaska", "American Samoa", "Arizona",
        "Arkansas", "California", "Colorado", "Connecticut",
        "Delaware", "District of Columbia", "Federated States of Micronesia",
        "Florida", "Georgia", "Guam", "Hawaii", "Idaho",
        "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky",
        "Louisiana", "Maine", "Marshall Islands", "Maryland",
        "Massachusetts", "Michigan", "Minnesota", "Mississippi",
        "Missouri", "Montana", "Nebraska", "Nevada",
        "New Hampshire", "New Jersey", "New Mexico", "New York",
        "North Carolina", "North Dakota", "Northern Mariana Islands", "Ohio",
        "Oklahoma", "Oregon", "Palau", "Pennsylvania", "Puerto Rico",
        "Rhode Island", "South Carolina", "South Dakota", "Tennessee",
        "Texas", "Utah", "Vermont", "Virgin Island", "Virginia",
        "Washington", "West Virginia", "Wisconsin", "Wyoming",
    };

    private async Task<IEnumerable<string>> AutoComplete(string value)
    {
        // In real life use an asynchronous function for fetching data from an api.
        await Task.Delay(5);

        // if text is null or empty, don't return values (drop-down will not open)
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return states.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
