#pragma checksum "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29311bba414b2294745a294afd0842d464cd30ea"
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
    public partial class MiniEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "w3-modal" + " " + (
#nullable restore
#line 1 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                      showModalCss

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "w3-modal-content w3-round-xlarge");
            __builder.AddMarkupContent(4, "<header class=\"w3-container w3-center w3-xlarge\">\r\n            Edit Mini\r\n        </header>");
#nullable restore
#line 6 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
         if (mini != null) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "w3-container bg");
            __builder.AddMarkupContent(7, "<label>Name</label>\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "class", "w3-input w3-margin-bottom");
            __builder.AddAttribute(10, "style", "background-color:inherit; color:inherit;");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                                            mini.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mini.Name = __value, mini.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.AddMarkupContent(14, "<label>Replicas</label>\r\n            ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "number");
            __builder.AddAttribute(17, "class", "w3-input w3-margin-bottom");
            __builder.AddAttribute(18, "style", "background-color:inherit; color:inherit;");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                                                          mini.Replicas

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mini.Replicas = __value, mini.Replicas, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, "<label>Size</label>\r\n            ");
            __builder.OpenElement(23, "select");
            __builder.AddAttribute(24, "class", "w3-input w3-margin-bottom");
            __builder.AddAttribute(25, "style", "background-color:inherit; color:inherit;");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                           mini.Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mini.Size = __value, mini.Size));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 14 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                 foreach (MiniSize size in Enum.GetValues(typeof(MiniSize))){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", 
#nullable restore
#line 15 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                    size

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, 
#nullable restore
#line 15 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                           size.Description()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "w3-margin-top w3-margin-bottom");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "w3-row");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "w3-button" + " " + (
#nullable restore
#line 20 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                            frontArtTab ? "tab-active" : "tab-inactive"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                                                                                     () => frontArtTab = true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Front Art");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "w3-button" + " " + (
#nullable restore
#line 21 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                            !frontArtTab? "tab-active" : "tab-inactive"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                                                                                     () => frontArtTab = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Back Art");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "w3-padding");
            __builder.AddAttribute(48, "style", "background-color: #2D232E;");
#nullable restore
#line 24 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                     if (frontArtTab) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "<label>URL</label>\r\n                    ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "class", "w3-input");
            __builder.AddAttribute(52, "style", "background-color:inherit; color:inherit;");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                                   mini.FrontArt.Url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mini.FrontArt.Url = __value, mini.FrontArt.Url));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.AddMarkupContent(56, "<div class=\"w3-center w3-padding\">\r\n                        OR\r\n                    </div>\r\n                    ");
            __builder.OpenComponent<PaperMiniMaker.Shared.FilePicker>(57);
            __builder.AddAttribute(58, "AsDataUrl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "OnFileLoad", new System.Action<System.String>(
#nullable restore
#line 30 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                                            (url) => { mini.FrontArt.Url = url; StateHasChanged(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 31 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                    } else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "w3-margin-bottom");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "type", "checkbox");
            __builder.AddAttribute(64, "class", "w3-check");
            __builder.AddAttribute(65, "checked", 
#nullable restore
#line 33 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                                                          mini.ReverseArt != null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                                                                                             toggleReverseArt

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(67, " \r\n                        ");
            __builder.AddMarkupContent(68, "<label>Use different art from front </label>");
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                    if (mini.ReverseArt != null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, "<label>URL</label>\r\n                        ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "class", "w3-input");
            __builder.AddAttribute(72, "style", "background-color:inherit; color:inherit;");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                                       mini.ReverseArt.Url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mini.ReverseArt.Url = __value, mini.ReverseArt.Url));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.AddMarkupContent(76, "<div class=\"w3-center w3-padding\">\r\n                            OR\r\n                        </div>\r\n                        ");
            __builder.OpenComponent<PaperMiniMaker.Shared.FilePicker>(77);
            __builder.AddAttribute(78, "AsDataUrl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "OnFileLoad", new System.Action<System.String>(
#nullable restore
#line 42 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                                                (url) => { mini.ReverseArt.Url = url; StateHasChanged(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 43 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                    }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.OpenElement(81, "footer");
            __builder.AddAttribute(82, "class", "w3-container w3-center");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "class", "w3-button");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
                                               save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "Done");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Colin\Documents\Git\PaperMiniMaker\Shared\MiniEditor.razor"
       
    [Parameter] public Action OnChange {get; set;}
    private Mini mini;

    private bool isOpen = false;
    private string showModalCss => isOpen ? "w3-show" : "w3-hide";

    private bool frontArtTab = true;

    public void Edit(Mini mini) {
        this.mini = mini;
        this.frontArtTab = true;
        this.isOpen = true;
        StateHasChanged();
    }

    public void save() {
        OnChange?.Invoke();
        this.isOpen = false;
    }

    private void toggleReverseArt(ChangeEventArgs e) {
        if (e.Value is bool && (bool)(e.Value) == true) {
            if (mini.ReverseArt == null) {
                mini.ReverseArt = new MiniArt {
                    Url = string.Empty,
                };
            }
        } else {
            mini.ReverseArt = null;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
