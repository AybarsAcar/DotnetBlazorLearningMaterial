#pragma checksum "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/LearnBlazorComponents/GrandChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "280ffdc9da30210c9c315c2007be3ec31f330239"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using HiddenVilla_Server.Model;

#line default
#line hidden
#nullable disable
    public partial class GrandChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "border mt-2");
            __builder.AddMarkupContent(2, "<div class=\"row\"><h3 class=\"text-primary col-12 pl-4 pt-2\">Grand Child Component</h3></div>\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "p");
            __builder.AddAttribute(6, "class", "pl-4 ml-2");
            __builder.AddContent(7, "There is a message - ");
            __builder.AddContent(8, 
#nullable restore
#line 6 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/LearnBlazorComponents/GrandChildComponent.razor"
                                                   MessageForGrandChild

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n        ");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "class", "pl-4 ml-2");
            __builder.AddContent(12, "LuckyNumber - ");
            __builder.AddContent(13, 
#nullable restore
#line 7 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/LearnBlazorComponents/GrandChildComponent.razor"
                                            MessageForGrandChild

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
#line 13 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/LearnBlazorComponents/GrandChildComponent.razor"
 
    [CascadingParameter(Name = "MessageFromGrandParent")]
    public string MessageForGrandChild { get; set; }

    [CascadingParameter(Name = "LuckNumberFromGrandParent")]
    public int LuckyNumberFromParent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
