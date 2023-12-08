using System.ComponentModel.DataAnnotations;

namespace FlightReservationSystem.Models
{
    public class Ticket
    {
        
        [Key] public int TicketId { get; set; }
        public double Price { get; set; }
        public string DepaturePoint { get; set; }
        
        public string ArrivalPoint {  get; set; }
        public DateOnly DateTime {  get; set; }
        public int NumberOfPeople { get; set; }
        public int FlightTime { get; set; }
        public string TicketHolder {  get; set; }
    }
}
