using FlexybookWebApp.Models;

namespace FlexybookWebApp.Services
{
    public class LocationService : ILocationService
    {
        private readonly HttpClient _httpClient;
        private readonly List<LocationModel> _mockLocations;

        public LocationService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _mockLocations = new List<LocationModel>
            {
                new LocationModel
                {
                    Id = "aalborg",
                    Name = "Aalborg",
                    Address = "Østergade 27, 9000 - Aalborg",
                    Phone = "45 11 22 33 44",
                    Email = "aalborg@flexybox.com",
                    IsOpen = true,
                    IsFavorite = false,
                    ImageUrl = "/images/location-aalborg.jpg",
                    OpeningHours = new[]
                    {
                        new OpeningHour { Day = "Monday - Thursday", Hours = "07:00 - 22:00" },
                        new OpeningHour { Day = "Friday", Hours = "07:00 - 22:00" },
                        new OpeningHour { Day = "Saturday", Hours = "07:00 - 22:00" },
                        new OpeningHour { Day = "Sunday", Hours = "07:00 - 22:00" },
                        new OpeningHour { Day = "Holidays", Hours = "Closed" }
                    }
                }
            };
        }

        public Task<LocationModel?> GetLocationAsync(string id)
        {
            var location = _mockLocations.FirstOrDefault(l =>
                l.Id.Equals(id, StringComparison.OrdinalIgnoreCase));

            return Task.FromResult(location);
        }

        public Task<LocationModel[]> GetLocationsAsync()
        {
            return Task.FromResult(_mockLocations.ToArray());
        }

        public Task<bool> ToggleFavoriteAsync(string id)
        {
            var location = _mockLocations.FirstOrDefault(l =>
                l.Id.Equals(id, StringComparison.OrdinalIgnoreCase));

            if (location != null)
            {
                location.IsFavorite = !location.IsFavorite;
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}