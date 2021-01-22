#pragma checksum "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d897a43651f94f366297f455a1a2bc2e6b0168a8"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio.Components.Expriences
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio.Components.Projects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
using Portfolio.Services;

#line default
#line hidden
#nullable disable
    public partial class Experience : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Row>(0);
            __builder.AddAttribute(1, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 2 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
             Margin.Is4.FromTop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Column>(3);
                __builder2.AddAttribute(4, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 3 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                        ColumnSize.Is1.OnDesktop.IsAuto.OnMobile

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Column>(6);
                __builder2.AddAttribute(7, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 4 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                        ColumnSize.IsFull.OnMobile.Is3.OnDesktop

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Tooltip>(9);
                    __builder3.AddAttribute(10, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                        CompanyName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(12, "img");
                        __builder4.AddAttribute(13, "src", 
#nullable restore
#line 6 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                       ImagePath

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(14, "alt", 
#nullable restore
#line 6 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                                         $"{CompanyName} logo"

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(15, "id", "logo");
                        __builder4.AddAttribute(16, "b-1ufhgvipu6");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Column>(18);
                __builder2.AddAttribute(19, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 9 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                        ColumnSize.IsFull.OnMobile.Is4.OnDesktop

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Class", "align-self-center");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Heading>(22);
                    __builder3.AddAttribute(23, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.HeadingSize>(
#nullable restore
#line 10 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                       HeadingSize.Is4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Alignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.TextAlignment>(
#nullable restore
#line 10 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                                                   TextAlignment.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(26, 
#nullable restore
#line 10 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                                                                          JobTitle

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Column>(28);
                __builder2.AddAttribute(29, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 12 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                        ColumnSize.IsFull.OnMobile.IsAuto.OnDesktop

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Class", "align-self-center");
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Text>(32);
                    __builder3.AddAttribute(33, "Alignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.TextAlignment>(
#nullable restore
#line 13 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                         TextAlignment.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(35, 
#nullable restore
#line 14 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
             JobStart.ToString("MM.yyyy")

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(36, " - ");
                        __builder4.AddContent(37, 
#nullable restore
#line 14 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                                              JobEnd?.ToString("MM.yyyy") ?? "now"

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Column>(39);
                __builder2.AddAttribute(40, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 17 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                        ColumnSize.Is2.OnDesktop

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.OpenComponent<Blazorise.Row>(42);
            __builder.AddAttribute(43, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 19 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
             Margin.Is3.FromTop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Column>(45);
                __builder2.AddAttribute(46, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 20 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                        ColumnSize.Is2.OnDesktop

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Column>(48);
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Paragraph>(50);
                    __builder3.AddAttribute(51, "Alignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.TextAlignment>(
#nullable restore
#line 22 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                              TextAlignment.Justified

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(53, 
#nullable restore
#line 23 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
             JobDescription

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Column>(55);
                __builder2.AddAttribute(56, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 26 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
                        ColumnSize.Is2.OnDesktop

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Expriences\Experience.razor"
       

    [Parameter]
    public string CompanyName { get; set; }

    [Parameter]
    public string JobTitle { get; set; }

    [Parameter]
    public DateTime JobStart { get; set; }

    [Parameter]
    public DateTime? JobEnd { get; set; }

    [Parameter]
    public string JobDescription { get; set; }

    private string ImagePath => CompanyImageService.Images[CompanyName];

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591