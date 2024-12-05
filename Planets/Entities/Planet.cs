using System.ComponentModel.DataAnnotations;

namespace Planets.Entities
{
    public class Planet
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; }
        public int DiameterInKm {  get; set; }
        public double DistanceFromSunInAu {  get; set; }
        public int NumberOfMoons {  get; set; }
        public string Notes {  get; set; }
    }
}
