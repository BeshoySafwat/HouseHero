namespace DAL.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public Provider? provider { get; set; }
        public Customer? Customer { get; set; }
    }
}
