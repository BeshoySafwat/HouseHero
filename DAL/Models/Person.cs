using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int? Age { get; set; }
        public string PasswordHashed { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        [Display(Name = "Profile Picture")]
        public int? ProfilePicture_ID { get; set; }
        public string Address { get; set; } = null!;

        public int CityId { get; set; }
        public City City { get; set; } = null!;
    }

}
