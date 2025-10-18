namespace FlexybookWebApp.Models
{
    public class LocationModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsOpen { get; set; }
        public bool IsFavorite { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string InfoUrl { get; set; } = string.Empty;
        public string LeadingvisualsURL { get; set; } = string.Empty;
        public string[]? Images { get; set; }
        public OpeningHour[] OpeningHours { get; set; } = Array.Empty<OpeningHour>();

        public Dictionary<string, OpeningHour[]> ServiceOpeningHours { get; set; } = new Dictionary<string, OpeningHour[]>();
    }

    public class OpeningHour
    {
        public string Day { get; set; } = string.Empty;
        public string Hours { get; set; } = string.Empty;
    }
}
