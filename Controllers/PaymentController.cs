using CodeFirstVenueBooking.Models;
using Microsoft.AspNetCore.Mvc;
using CodeFirstVenueBooking.Repositories;

namespace CodeFirstVenueBooking.Controllers
{
    public class PaymentController : Controller
    {
        IPaymentRepo repository;
        public PaymentController(IPaymentRepo repo)
        {
            this.repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository.GetAllPayments());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Payment payment)
        {
            repository.AddNewPayment(payment);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Payment payment = repository.GetPaymentById(id);
            if (payment != null)
                return View(payment);
            else

                return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Payment payment)
        {
            repository.UpdatePayment(payment);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            Payment payment = repository.GetPaymentById(id);
            if (payment != null)
                return View(payment);
            else

                return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Payment payment)
        {
            repository.DeletePayment(payment.Bno);
            return RedirectToAction("Index");

        }
    }   
}
