using DemoWebAPI.Model;

namespace DemoWebAPI.data
{
    public class CitiesData
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesData current = new CitiesData();
        public CitiesData() {
            Cities = new List<CityDto>() {
                new CityDto() { Id = 1, Name = "Lyon" },
                new CityDto() { Id = 2, Name = "Paris" },
                new CityDto() { Id = 3, Name = "Marseille" }
            };
        }

    }
}
