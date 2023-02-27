using CodeFirstVenueBooking.Models;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirstVenueBooking.Repositories
{
    public class BookingRepo : IBookingRepo
    {

        MyDbContext context;
        public BookingRepo(MyDbContext bookingcontext)
        {
            context = bookingcontext;
        }
       

        public void AddNewBooking(Booking booking)
        {
            context.Bookings.Add(booking);
            context.SaveChanges();
        }

        public void DeleteBooking(int id)
        {
            Booking booking = context.Bookings.FirstOrDefault(booking => booking.Bno == id);
            if (booking != null)
            {
                context.Bookings.Remove(booking);
                context.SaveChanges();
            }

        }
        public List<Booking> GetAllBookings()
        {
            return context.Bookings.ToList();

        }
        public Booking GetBookingById(int id)
        {
            Booking booking = context.Bookings.Find(id);

            return booking;
        }
        public void UpdateBooking(Booking newbooking)
        {
            Booking booking = context.Bookings.FirstOrDefault(booking=> booking.Bno == newbooking.Bno);
            if (booking != null)
            {
                booking.BDate = newbooking.BDate;
                booking.EventName = newbooking.EventName;
                booking.UserName = newbooking.UserName;
                booking.Price = newbooking.Price;
                booking.SelectType = newbooking.SelectType;
                booking.SelectName = newbooking.SelectName;

                context.SaveChanges();
            }

        }
    }
}