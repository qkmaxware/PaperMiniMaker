#pragma checksum "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniDrawer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b74374cea95069d16bf954e67c2edb0799380ad8"
// <auto-generated/>
#pragma warning disable 1591
namespace PaperMiniMaker.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Colin\Documents\Git\PaperMiniMaker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Colin\Documents\Git\PaperMiniMaker\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Colin\Documents\Git\PaperMiniMaker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Colin\Documents\Git\PaperMiniMaker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Colin\Documents\Git\PaperMiniMaker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Colin\Documents\Git\PaperMiniMaker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Colin\Documents\Git\PaperMiniMaker\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Colin\Documents\Git\PaperMiniMaker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Colin\Documents\Git\PaperMiniMaker\_Imports.razor"
using PaperMiniMaker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Colin\Documents\Git\PaperMiniMaker\_Imports.razor"
using PaperMiniMaker.Shared;

#line default
#line hidden
#nullable disable
    public partial class MiniDrawer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mini" + " " + (
#nullable restore
#line 1 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniDrawer.razor"
                  Mini.Size.CssClass()

#line default
#line hidden
#nullable disable
            ) + " w3-margin");
            __builder.AddMarkupContent(2, "<div class=\"foot back\"></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "art back");
            __builder.OpenElement(5, "img");
            __builder.AddAttribute(6, "class", "pixelart");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 6 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniDrawer.razor"
                                    Mini.GetReverseArt().Url

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "art front");
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "class", "pixelart");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 9 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniDrawer.razor"
                                    Mini.FrontArt.Url

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    <div class=\"foot front\"></div>\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "base");
            __builder.OpenElement(17, "span");
            __builder.AddContent(18, 
#nullable restore
#line 15 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniDrawer.razor"
               Mini.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniDrawer.razor"
       
    [Parameter] public Mini Mini {get; set;}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
