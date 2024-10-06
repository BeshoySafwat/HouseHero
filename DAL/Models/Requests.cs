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
    public class Requests
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public DateTime RequestDate { get; set; }
        public string Prefered_Communction { get; set; } = null!;
        public Status status {  get; set; } 
        public Customer Customer { get; set; } = null!;
        public Provider Provider { get; set; } = null!;
        public Service Service { get; set; } = null!;
    }
}
