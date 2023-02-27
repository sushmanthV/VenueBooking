using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstVenueBooking.Models
{
    public class Booking
    {
        [Key] 
        public int Bno { get; set; }
        
        public DateTime BDate { get; set; }
        public string EventName { get; set; }
        public string UserName { get; set; }
        public int Price { get; set; } 
        public string SelectType { get; set; }
        public string SelectName  { get; set; }
    }
}
