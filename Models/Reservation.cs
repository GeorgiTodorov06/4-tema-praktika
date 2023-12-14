namespace _4_tema_praktika.Models
{
    public class Reservation
    {
        public Customer Customer { get; set; }
        public string DataTime { get; set; }
        public Table Table { get; set; }
        public string Description { get; set; }

    }
}
