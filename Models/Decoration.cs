using System.ComponentModel.DataAnnotations;

namespace CodeFirstVenueBooking.Models
{
    public class Decoration
    {
        [Key] 
        public int Id { get; set; }
       
        public string EventName { get; set; }
        
        public int Price { get; set; }
    }
}
