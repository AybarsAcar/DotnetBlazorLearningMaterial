#pragma checksum "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/LearnBlazorComponents/AnotherChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c36c50b985a3d239109681f2c710fd6c5f1c4c0"
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
    public partial class AnotherChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<h4 class=\"text-primary pt-3\">Another Child Component</h4>\n    ");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "class", "form-control");
            __builder.AddAttribute(4, "id", "roomName");
            __builder.AddAttribute(5, "placeholder", "Initial Text");
            __builder.AddMultipleAttributes(6, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 3 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/LearnBlazorComponents/AnotherChildComponent.razor"
                                                                                      InputAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/LearnBlazorComponents/AnotherChildComponent.razor"
 
    // [Parameter]
    // public string Placeholder { get; set; }
    //
    // [Parameter]
    // public string Required { get; set; } = "required";
    //
    // [Parameter]
    // public string MaxLength { get; set; } = "10";

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> InputAttributes { get; set; } = new Dictionary<string, object>();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
