using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TestRDP.Models
{ 
    public class Response
    {
        public DateTime RegistrationDate { get { return RegistrationDate; } set { RegistrationDate = DateTime.Now; } }
        public long Token { get; set; }
        [Key]
        public int CardId { get; set; }
    }
}
