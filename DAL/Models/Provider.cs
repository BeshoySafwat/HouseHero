using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Age { get; set; }
        public string Bio { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Rating { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;
        
        public ICollection<Protfolio_item> protfolio_Item { get; set; }= new HashSet<Protfolio_item>();
        public  ICollection<Available_Day> available_Day { get; set; } = new HashSet<Available_Day>();
        [ForeignKey("City")]
        public int cityId { get; set; }
        public City City { get; set; } = null!;
    }
}
