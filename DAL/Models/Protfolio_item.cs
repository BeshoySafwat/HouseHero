using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Protfolio_item
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Bio { get; set; } = null!;
        [ForeignKey("Provider")]
        public int ProviderId { get; set; }
        public Provider Provider { get; set; } = null!;
        public ICollection<Protfolio_image> Protfolio_Image { get; set; } = new HashSet<Protfolio_image>();
    }
}
