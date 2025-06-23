using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace BulgariaMapApp.Pages
{
    public class MapModel : PageModel
    {
        public List<Flag> Flags { get; set; }

        public void OnGet()
        {
            Flags = new List<Flag>
            {
                new Flag { Id = 1, Name = "Sofia", Latitude = 42.6977, Longitude = 23.3219, FlagUrl = "https://flagcdn.com/w320/bg.png" },
                new Flag { Id = 2, Name = "Plovdiv", Latitude = 42.1354, Longitude = 24.7453, FlagUrl = "https://flagcdn.com/w320/bg.png" },
                new Flag { Id = 3, Name = "Varna", Latitude = 43.2141, Longitude = 27.9147, FlagUrl = "https://flagcdn.com/w320/bg.png" },
                new Flag { Id = 4, Name = "Burgas", Latitude = 42.5048, Longitude = 27.4626, FlagUrl = "https://flagcdn.com/w320/bg.png" }
            };
        }
    }

    public class Flag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string FlagUrl { get; set; }
    }
}
