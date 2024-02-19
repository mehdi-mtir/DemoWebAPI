using DemoWebAPI.Model;

namespace DemoWebAPI.data
{
    public class CitiesData
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesData current = new CitiesData();
        public CitiesData() {
            Cities = new List<CityDto>() {
                new CityDto() { 
                    Id = 1, 
                    Name = "Lyon",
                    Description = "La ville des lumières",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Ruines antiques",
                            Description = "Ancien théâtre antique"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Parc de la tête d'or",
                            Description = "Plus grand parc de Lyon avec un Zoo"
                        }
                    }
                },
                new CityDto() { 
                    Id = 2, 
                    Name = "Paris",
                    Description = "Capitale française",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Tour eiffel",
                            Description = "Monument touritique",
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Le musée du Louvre",
                            Description = "Domicile de la Joconde"
                        }
                    }
                },
                new CityDto() { 
                    Id = 3, 
                    Name = "Marseille",
                    Description = "Cité phocéenne",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Le vieux port",
                            Description = "Port mythique",
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Le vélodrôme",
                            Description = "Stade de l'OM"
                        }
                    }
                }
            };
        }

    }
}
