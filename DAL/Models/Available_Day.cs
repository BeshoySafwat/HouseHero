using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    //public enum Week
    //{
    //    الاحد,
    //    الاثنين,

    //}
    public class Available_Day
    {
        public int Id {  get; set; }
        public DateTime Day { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }

        public int ProviderId {  get; set; }
        public Provider Provider { get; set; } = null!;
    }
}
