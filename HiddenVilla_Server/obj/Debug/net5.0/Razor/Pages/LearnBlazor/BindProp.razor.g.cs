#pragma checksum "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7ced272891b5fe4c5b5421a5235d540604be804"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor
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
#line 2 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
using HiddenVilla_Server.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bindProp")]
    public partial class BindProp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light border p-2");
            __builder.AddMarkupContent(2, "<h2 class=\"bg-light border p-2\">\n        First Room\n    </h2>\n    Room: ");
            __builder.AddContent(3, 
#nullable restore
#line 8 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
           Room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\n    <br>\n    Room: ");
            __builder.AddContent(5, 
#nullable restore
#line 10 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
           Room.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\n    <br>\n\n    ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "number");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                                       Room.Price

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.Price = __value, Room.Price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    <br>\n\n    ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "checkbox");
            __builder.AddAttribute(14, "checked", 
#nullable restore
#line 16 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                                                                   Room.IsActive ? "checked" : null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                                         Room.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.IsActive = __value, Room.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, " &nbsp; Is Active\n    ");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, "The room is ");
            __builder.AddContent(20, 
#nullable restore
#line 17 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                     Room.IsActive ? "active" : "not active"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n\n    ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                   SelectedRoomProp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedRoomProp = __value, SelectedRoomProp));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 20 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
         foreach (var prop in Room.RoomProps)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", 
#nullable restore
#line 22 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                            prop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, 
#nullable restore
#line 22 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                                        prop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 23 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n\n    ");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, "The Room Prop selected is: ");
            __builder.AddContent(31, 
#nullable restore
#line 26 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                                   SelectedRoomProp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n\n");
            __builder.OpenElement(33, "div");
            __builder.AddMarkupContent(34, "<br>\n    ");
            __builder.AddMarkupContent(35, "<h2 class=\"text-info\">Room List</h2>\n    ");
            __builder.OpenElement(36, "table");
            __builder.AddAttribute(37, "class", "table table-dark");
#nullable restore
#line 33 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
         foreach (var room in RoomsList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "tr");
            __builder.OpenElement(39, "td");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "text");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                                                    room.RoomName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.RoomName = __value, room.RoomName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                ");
            __builder.OpenElement(45, "td");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "text");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                                                    room.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.Price = __value, room.Price));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                 foreach (var roomProp in room.RoomProps)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 45 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                         roomProp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, " - ");
            __builder.AddContent(53, 
#nullable restore
#line 45 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                                          roomProp.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 46 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 49 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n    \n    <hr>");
#nullable restore
#line 53 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
     foreach (var room in RoomsList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "p");
            __builder.AddContent(56, 
#nullable restore
#line 55 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
            room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " is $");
            __builder.AddContent(58, 
#nullable restore
#line 55 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
                               room.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 56 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
 
    string SelectedRoomProp = "";
    List<BlazorRoom> RoomsList = new List<BlazorRoom>();

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/BindProp.razor"
 

    BlazorRoom Room = new BlazorRoom()
    {
        Id = 1,
        Price = 499,
        IsActive = false,
        RoomName = "Villa Suite",
        RoomProps = new List<BlazorRoomProp>()
        {
            new Model.BlazorRoomProp
            {
                Id = 1, Name = "Sq Ft", Value = "100"
            },
            new Model.BlazorRoomProp
            {
                Id = 2, Name = "Occupancy", Value = "3"
            }
        }
    };

    protected override void OnInitialized()
    {
        base.OnInitialized();
        RoomsList.Add(new BlazorRoom()
        {
            Id = 1,
            Price = 499,
            IsActive = false,
            RoomName = "Villa Suite",
            RoomProps = new List<BlazorRoomProp>()
            {
                new Model.BlazorRoomProp
                {
                    Id = 1, Name = "Sq Ft", Value = "100"
                },
                new Model.BlazorRoomProp
                {
                    Id = 2, Name = "Occupancy", Value = "3"
                }
            }
        });
        RoomsList.Add(new BlazorRoom()
        {
            Id = 2,
            Price = 399,
            IsActive = false,
            RoomName = "Villa Suite One Bed Room",
            RoomProps = new List<BlazorRoomProp>()
            {
                new Model.BlazorRoomProp
                {
                    Id = 1, Name = "Sq Ft", Value = "100"
                },
                new Model.BlazorRoomProp
                {
                    Id = 2, Name = "Occupancy", Value = "3"
                }
            }
        });
        RoomsList.Add(new BlazorRoom()
        {
            Id = 3,
            Price = 699,
            IsActive = false,
            RoomName = "Villa Suite Two Bed Room",
            RoomProps = new List<BlazorRoomProp>()
            {
                new Model.BlazorRoomProp
                {
                    Id = 1, Name = "Sq Ft", Value = "100"
                },
                new Model.BlazorRoomProp
                {
                    Id = 2, Name = "Occupancy", Value = "3"
                }
            }
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
