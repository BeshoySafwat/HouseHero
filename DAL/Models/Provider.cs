using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    //Base Class
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Age { get; set; }
        public string Bio { get; set; } = null!;
        [Display(Name = "Profile Picture")]
        public int ProfilePicture_ID { get; set; }
        public string PasswordHash { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Rating { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;

        public int CityId { get; set; }
        public City City { get; set; } = null!;

        public ICollection<Protfolio_item>? Protfolio_Item { get; set; }= new HashSet<Protfolio_item>();
        //Enums Days
        public  ICollection<Available_Day>? Available_Day { get; set; } = new HashSet<Available_Day>();
        public  ICollection<Review>? Reviews { get; set; } = new HashSet<Review>();
        public  ICollection<SavedProvider>? Saved { get; set; } = new HashSet<SavedProvider>();
        public ICollection<Requests> Requests { get; set; } = new HashSet<Requests>();


    }
}
