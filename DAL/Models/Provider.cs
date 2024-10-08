using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    //Base Class
    public class Provider : Person
    {

        public string? Bio { get; set; } = null!;
        public int Rating { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }

        public int? ServiceId { get; set; }
        public Service? Service { get; set; } = null!;

        public ICollection<Protfolio_item>? Protfolio_Item { get; set; } = new HashSet<Protfolio_item>();
        public ICollection<Available_Day>? Available_Day { get; set; } = new HashSet<Available_Day>();
        public ICollection<Review>? Reviews { get; set; } = new HashSet<Review>();
        public ICollection<SavedProvider>? Saved { get; set; } = new HashSet<SavedProvider>();
        public ICollection<Requests>? Requests { get; set; } = new HashSet<Requests>();
    }
}
