namespace Alex.Models
{
    public class Availability
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsFullDay { get; set; }
    }
}
