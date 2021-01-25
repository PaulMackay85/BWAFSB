#pragma checksum "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9d037f90374ebe0eebe873c1a2c61c33e238412"
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
#line 1 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/leaderboard")]
    public partial class Leaderboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Leaderboard</h3>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
 if (LeaderboardService.Leaderboard == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "\t");
            __builder.AddMarkupContent(2, "<span>Loading Leaderboard...</span>\r\n");
#nullable restore
#line 10 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "\t");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n\t\t");
            __builder.AddMarkupContent(7, "<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>#</th>\r\n\t\t\t\t<th>User</th>\r\n\t\t\t\t<th>Victories</th>\r\n\t\t\t\t<th>Defeats</th>\r\n\t\t\t\t<th>Battles</th>\r\n\t\t\t\t<th></th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 25 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
             foreach (BlazorBattles.Shared.UserStatistic entry in LeaderboardService.Leaderboard)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "\t\t\t");
            __builder.OpenElement(11, "tr");
            __builder.AddAttribute(12, "style", 
#nullable restore
#line 27 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
                        GetMyStyle(entry.UserId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n\t\t\t\t");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 28 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
                     entry.Rank

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\t\t\t\t");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 29 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
                     entry.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\t\t\t\t");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 30 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
                     entry.Victories

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\t\t\t\t");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 31 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
                     entry.Defeats

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\t\t\t\t");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 32 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
                     entry.Battles

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\t\t\t\t");
            __builder.OpenElement(29, "td");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 34 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
                 if (entry.UserId != myUserId)
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "\t\t\t\t\t");
            __builder.AddMarkupContent(32, "<button class=\"btn btn-primary\">Fight</button>\r\n");
#nullable restore
#line 37 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 40 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
			}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 43 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
          

		int myUserId;

	protected override async Task OnInitializedAsync()
	{
		await LeaderboardService.GetLeaderboard();

		var authState = await AuthStateProvider.GetAuthenticationStateAsync();
		myUserId = int.Parse(authState.User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value);
	}

	public string GetMyStyle(int userId)
	{
		if (userId == myUserId)
			return "color: green; font-weight: 600;";
		else
			return string.Empty;
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattles.Client.Services.ILeaderboardService LeaderboardService { get; set; }
    }
}
#pragma warning restore 1591