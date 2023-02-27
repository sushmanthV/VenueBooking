using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstVenueBooking.Models
{
    public class Payment
    {

        [Key]
        public int Bno { get; set; }
        public DateTime BDate { get; set; }
        public int Amount { get; set; }
        public string EventType { get; set; }
        public string UserName { get; set; }
        public string PaymentType { get; set; }
        public string Details { get; set; }
    }

    
}

