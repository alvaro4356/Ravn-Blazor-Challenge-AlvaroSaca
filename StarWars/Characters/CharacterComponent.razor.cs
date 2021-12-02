using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using StarWars.Core.DataService;

namespace StarWars.Characters
{
    public partial class CharacterComponent:ComponentBase
    {
        [Parameter] public string Name { get; set; }
        public Character CharacterInfo { get; set; }

        protected override async Task OnInitializedAsync()
        {
        var encoded = Uri.EscapeUriString(Name);
            Logger.LogDebug($"Url encoded character name:{encoded} ");
            var response = await Http.GetFromJsonAsync<SwApiListResponse>(Http.BaseAddress.ToString() + $"people/?search={encoded}");
            CharacterInfo = response.Results[0];
        }
    }
}
