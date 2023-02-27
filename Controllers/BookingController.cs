using CodeFirstVenueBooking.Models;
using CodeFirstVenueBooking.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstVenueBooking.Controllers
{
    public class BookingController : Controller
    {


        IBookingRepo repository;
        public BookingController(IBookingRepo repo)
        {
            this.repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.GetAllBookings());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            repository.UpdateBooking(booking);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Booking booking = repository.GetBookingById(id);
            if (booking != null)
                return View(booking);
            else

                return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Booking booking)
        {
            repository.UpdateBooking(booking);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            Booking booking = repository.GetBookingById(id);
            if (booking != null)
                return View(booking);
            else

                return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Booking booking)
        {
            repository.DeleteBooking(booking.Bno);
            return RedirectToAction("Index");

        }

    }
}
