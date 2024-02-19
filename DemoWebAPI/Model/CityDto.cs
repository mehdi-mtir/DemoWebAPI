namespace DemoWebAPI.Model
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public List<PointOfInterestDto> PointOfInterests { get; set;} = new List<PointOfInterestDto>();

        public int NumberOfPointOfInterest { 
            get
            {
                return PointOfInterests.Count;
            }
        }

    }
}
