using System.ComponentModel.DataAnnotations;

namespace FlightReservationSystem.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

    }
}
