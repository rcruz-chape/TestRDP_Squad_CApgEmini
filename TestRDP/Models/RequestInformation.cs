using System.ComponentModel.DataAnnotations;

namespace TestRDP.Models
{
    public class RequestInformation

    { 
        [Key]
        public int CustomerId { get; set; }
        public int CardId { get; set; }
        public long Token { get; set; }
        public int  CVV { get; set;}
    }
}
