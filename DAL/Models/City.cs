namespace DAL.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection< Provider>? provider { get; set; }=new HashSet<Provider>();
        public ICollection< Customer>? Customers { get; set; }=new HashSet<Customer>();

    }
}
