using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWars.Characters;
namespace StarWars.Core.DataService
{
    public class SwApiListResponse
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; } 
        public Character[] Results { get; set; }




    }
}
