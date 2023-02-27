using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstVenueBooking.Models
{
    public class CustomerEventDetails
    {
        [Key] 
        public string EventName { get; set; }
        public int People { get; set; }
        public DateTime EventDate { get; set; }
        public string Details { get; set; }
        public string UserName { get; set; }

    }
}
