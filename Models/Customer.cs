namespace _4_tema_praktika.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Reservation> Reservations { get; set; }

    }
}
