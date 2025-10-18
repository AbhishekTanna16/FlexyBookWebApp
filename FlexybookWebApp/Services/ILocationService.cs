using FlexybookWebApp.Models;

namespace FlexybookWebApp.Services
{
    public interface ILocationService
    {
        Task<LocationModel?> GetLocationAsync(string id);
        Task<LocationModel[]> GetLocationsAsync();
        Task<bool> ToggleFavoriteAsync(string id);
    }
}