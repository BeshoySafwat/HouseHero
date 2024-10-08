using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public enum Status
    { 
        Accepted = 1,
        rejected = 2,
        on_Review=3
    };
    public enum Prefered_Communction
    {
        whatsapp,
        call
    }
    public class Requests
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public DateTime RequestDate { get; set; }
        public Prefered_Communction Prefered { get; set; }
        public string? Comment { get; set; } = null!;
        public Status Status {  get; set; } 
        public Customer Customer { get; set; } = null!;
        public Provider Provider { get; set; } = null!;
        public Service Service { get; set; } = null!;
    }
}
