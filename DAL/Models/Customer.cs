using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } =  null!;
        public int Age { get; set; }
        public string PasswordHashed { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Profile_Url { get; set; } = null!;    
        public string Address { get; set; } = null!;
        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; } = null!;
    }
}
