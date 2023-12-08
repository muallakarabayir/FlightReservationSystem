using System.ComponentModel.DataAnnotations;

namespace FlightReservationSystem.Models
{
    public class Passenger
    {

        [Key] public int Id {  get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name="Name")]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "Mail")]
        public string Email { get; set; }
        [Required]
        [MaxLength(11)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string Gender {  get; set; }
        
        public int Age {  get; set; }
    }
}
