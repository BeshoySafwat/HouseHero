using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Profile Picture")]
        public int ProfilePicture_ID { get; set; }
        public string Address { get; set; } = null!;
        public int CityId { get; set; }

        public City City { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
        public ICollection<SavedProvider> SavedProviders { get; set; } =new HashSet<SavedProvider>();
        //
        public ICollection<Requests> Requests { get; set; } =new HashSet<Requests>();
    }
}
