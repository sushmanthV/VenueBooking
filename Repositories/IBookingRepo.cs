using CodeFirstVenueBooking.Models;
using System.Collections.Generic;

namespace CodeFirstVenueBooking.Repositories
{
    public interface IBookingRepo
    {
        List<Booking> GetAllBookings();
        void AddNewBooking(Booking booking);
        void UpdateBooking(Booking booking);
        
        Booking GetBookingById(int id);
        void DeleteBooking(int id);
    }
}
