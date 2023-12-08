using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightReservationSystem.Models
{
    public class Ticket
    {
        
        [Key] public int TicketId { get; set; }

        public double Price { get; set; }
        [MaxLength(15)]
        public string DepaturePoint { get; set; }
        [MaxLength(15)]
        public string ArrivalPoint {  get; set; }
        public DateOnly DateTime {  get; set; }
        public int FlightTime { get; set; }

        [ForeignKey("Plane")] public int PlaneId { get; set; }
        public Plane Plane { get; set; }

       [ForeignKey("Passenger")] public int TicketHolderId {  get; set; }
        public Passenger Passenger { get; set; }
        public string TicketHolder {  get; set; }
    }
}
