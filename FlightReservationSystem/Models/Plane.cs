using System.ComponentModel.DataAnnotations;

namespace FlightReservationSystem.Models
{
    public class Plane
    {
        [Key] public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(75,100)]
        public int NumberOfSeats {  get; set; } 
        public ICollection<Passenger> Passengers { get; set; }
        
       
    }
}
