namespace DAL.Models
{
    public class Protfolio_image
    {
        public int Id {  get; set; }
        public string Img_Url { get; set; } = null!;
        public int ProtfolioId { get; set; }
        public Protfolio_item Protfolio_Item { get; set; } = null!;
    }
}
