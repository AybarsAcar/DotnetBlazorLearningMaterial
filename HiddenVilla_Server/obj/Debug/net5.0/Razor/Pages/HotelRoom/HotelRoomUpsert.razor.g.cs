#pragma checksum "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68d29cf9dfc5162fd5e310fb24f441bfe517df70"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.HotelRoom
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
#nullable restore
#line 13 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/create")]
    public partial class HotelRoomUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(4, 
#nullable restore
#line 8 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " Hotel Room");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                  HotelRoomModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                                 HandleHotelRoomSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>Name</label>\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                HotelRoomModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Name = __value, HotelRoomModel.Name))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 21 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                () => HotelRoomModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n\n                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label>Occupancy</label>\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateInputNumber_1(__builder2, 34, 35, "form-control", 36, 
#nullable restore
#line 26 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                  HotelRoomModel.Occupancy

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Occupancy = __value, HotelRoomModel.Occupancy)), 38, () => HotelRoomModel.Occupancy);
                __builder2.AddMarkupContent(39, "\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_2(__builder2, 40, 41, 
#nullable restore
#line 27 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                () => HotelRoomModel.Occupancy

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label>Regular Rate</label>\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateInputNumber_3(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 32 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                  HotelRoomModel.RegularRate

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.RegularRate = __value, HotelRoomModel.RegularRate)), 50, () => HotelRoomModel.RegularRate);
                __builder2.AddMarkupContent(51, "\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_4(__builder2, 52, 53, 
#nullable restore
#line 33 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                () => HotelRoomModel.RegularRate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n\n                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label>Sq feet</label>\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                HotelRoomModel.SqFt

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.SqFt = __value, HotelRoomModel.SqFt))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.SqFt));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_5(__builder2, 64, 65, 
#nullable restore
#line 39 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                () => HotelRoomModel.SqFt

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n\n                    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddMarkupContent(69, "<label>Description</label>\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(70);
                __builder2.AddAttribute(71, "class", "form-control");
                __builder2.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                    HotelRoomModel.Details

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Details = __value, HotelRoomModel.Details))));
                __builder2.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.Details));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_6(__builder2, 76, 77, 
#nullable restore
#line 45 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                () => HotelRoomModel.Details

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\n\n                    ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group");
                __builder2.OpenElement(81, "button");
                __builder2.AddAttribute(82, "class", "btn btn-outline-success btn-group");
                __builder2.AddContent(83, 
#nullable restore
#line 49 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
                                                                           Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(84, " Room");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(86);
                __builder2.AddAttribute(87, "href", "hotel-room");
                __builder2.AddAttribute(88, "class", "btn btn-outline-secondary btn-group");
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(90, "Go Back");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/HotelRoom/HotelRoomUpsert.razor"
 
    private HotelRoomDTO HotelRoomModel { get; set; } = new HotelRoomDTO();
    private string Title { get; set; } = "Create";

    private async Task HandleHotelRoomSubmit()
    {
        // we can access the variables through the model
        var roomDetailByName = await _HotelRoomRepository.IsRoomUnique(HotelRoomModel.Name);

        if (roomDetailByName != null)
        {
            // room with that name already exists
            return;
        }

        var createdResult = await _HotelRoomRepository.CreateHotelRoom(HotelRoomModel);
        
        // Navigate back to the index page
        _NavigationManager.NavigateTo("hotel-room");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository _HotelRoomRepository { get; set; }
    }
}
namespace __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
