#pragma checksum "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b9e1cbca2a8b1cefed6fe34e9b834bfe015a727"
// <auto-generated/>
#pragma warning disable 1591
namespace StarWars.Characters
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Users\Lourdes\source\repos\StarWars\StarWars\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\Lourdes\source\repos\StarWars\StarWars\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Users\Lourdes\source\repos\StarWars\StarWars\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Users\Lourdes\source\repos\StarWars\StarWars\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Users\Lourdes\source\repos\StarWars\StarWars\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Users\Lourdes\source\repos\StarWars\StarWars\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Users\Lourdes\source\repos\StarWars\StarWars\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Users\Lourdes\source\repos\StarWars\StarWars\_Imports.razor"
using StarWars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Users\Lourdes\source\repos\StarWars\StarWars\_Imports.razor"
using StarWars.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/character/{name}")]
    public partial class CharacterComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor"
 if (CharacterInfo == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "                ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor"
}

else
{ 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddAttribute(4, "style", "width: 18rem;");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "h5");
            __builder.AddAttribute(10, "class", "card-title");
            __builder.AddContent(11, 
#nullable restore
#line 17 "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor"
                                CharacterInfo.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, "<p> <strong>General Information</strong></p>\r\n        <p></p>\r\n        ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "card-text");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddMarkupContent(17, "<span><strong>Birth date:</strong></span>\r\n            ");
            __builder.AddContent(18, 
#nullable restore
#line 22 "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor"
             CharacterInfo.BirthYear

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "card-text");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.AddMarkupContent(24, "<span><strong>Gender:</strong></span>\r\n            ");
            __builder.AddContent(25, 
#nullable restore
#line 26 "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor"
             CharacterInfo.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "card-text");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.AddMarkupContent(31, "<span><strong>Eye Color:</strong></span>\r\n            ");
            __builder.AddContent(32, 
#nullable restore
#line 30 "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor"
             CharacterInfo.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "p");
            __builder.AddAttribute(36, "class", "card-text");
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.AddMarkupContent(38, "<span><strong>Hair Color:</strong></span>\r\n            ");
            __builder.AddContent(39, 
#nullable restore
#line 34 "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor"
             CharacterInfo.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "p");
            __builder.AddAttribute(43, "class", "card-text");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.AddMarkupContent(45, "<span><strong>Height:</strong></span>\r\n            ");
            __builder.AddContent(46, 
#nullable restore
#line 38 "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor"
             CharacterInfo.Height

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n        ");
            __builder.OpenElement(49, "p");
            __builder.AddAttribute(50, "class", "card-text");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.AddMarkupContent(52, "<span><strong>Skin Color:</strong></span>\r\n            ");
            __builder.AddContent(53, 
#nullable restore
#line 43 "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor"
             CharacterInfo.SkinColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 47 "E:\Users\Lourdes\source\repos\StarWars\StarWars\Characters\CharacterComponent.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<CharacterComponent> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
