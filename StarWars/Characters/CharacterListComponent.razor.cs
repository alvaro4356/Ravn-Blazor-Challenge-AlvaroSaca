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
    public partial class CharacterListComponent : ComponentBase
    {
        public Character[] Characters { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Logger.LogDebug($"Requesting Star Wars characters from:" + Http.BaseAddress.ToString() + "people/");
            try {
                var response = await Http.GetFromJsonAsync<SwApiListResponse>(Http.BaseAddress.ToString() + "people/");
                Characters = response.Results;
            }

            catch(Exception ex)
            {
                Logger.LogError(ex, ex.Message);
            }
            
            
        }

    }
}
