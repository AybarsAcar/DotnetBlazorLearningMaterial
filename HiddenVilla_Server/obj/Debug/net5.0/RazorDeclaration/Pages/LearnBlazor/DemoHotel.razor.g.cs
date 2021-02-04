// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/demoHotel")]
    public partial class DemoHotel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/DemoHotel.razor"
 
    public int SelectedRooms { get; set; } = 0;
    public string SelectedAmenity { get; set; }

    List<BlazorRoom> RoomsList = new List<BlazorRoom>();
    List<HotelAmenities> AmenitiesList = new List<HotelAmenities>();

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/aybarsacar/Desktop/cs/DotnetBlazorLearningMaterial/HiddenVilla_Server/Pages/LearnBlazor/DemoHotel.razor"
 
    protected void AmenitySelectionChanged(string amenityName)
    {
        SelectedAmenity = amenityName;
    }

    /**
     * method to trigger the event whether a room has been selected or not
     */
    protected void SelectedRoomsCounterChanged(bool isSelected)
    {
        if (isSelected)
        {
            SelectedRooms++;
        }
        else
        {
            SelectedRooms--;
        }
    }

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

        AmenitiesList.Add(new HotelAmenities()
        {
            Id = 101,
            Name = "Gym",
            Description = "Hotel Gym open 24/7"
        });
        AmenitiesList.Add(new HotelAmenities()
        {
            Id = 102,
            Name = "Swimming Pool",
            Description = "Swimming pool open all day"
        });
        AmenitiesList.Add(new HotelAmenities()
        {
            Id = 103,
            Name = "Breakfast",
            Description = "Free breakfast for our customers"
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
