#pragma checksum "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Army.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bca1d73e6e036ff9759d76568184503c91cf18a0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBattles.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/army")]
    public partial class Army : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Army</h3>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
 foreach (var userUnit in UnitService.MyUnits)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "\t");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "army-list");
            __builder.AddMarkupContent(4, "\r\n\t\t");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 11 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
             switch (userUnit.UnitId)
				{
					case 1:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, " <img src=\"icons/W_Sword006.png\"> ");
#nullable restore
#line 13 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
                                                               break;
					case 2:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, " <img src=\"icons/S_Bow08.png\"> ");
#nullable restore
#line 14 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
                                                            break;
					case 3:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, " <img src=\"icons/C_Hat01.png\"> ");
#nullable restore
#line 15 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
                                                            break;
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\t\t");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\r\n\t\t\t");
            __builder.AddContent(14, 
#nullable restore
#line 19 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
             UnitService.Units.First(unit => unit.Id == userUnit.UnitId).Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\t\t");
            __builder.OpenElement(17, "div");
            __builder.AddMarkupContent(18, "\r\n\t\t\t");
            __builder.AddContent(19, 
#nullable restore
#line 22 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
             userUnit.HitPoints

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, " HP\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 25 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattles.Client.Services.IUnitService UnitService { get; set; }
    }
}
#pragma warning restore 1591
