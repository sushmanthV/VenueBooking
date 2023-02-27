using CodeFirstVenueBooking.Models;
using CodeFirstVenueBooking.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstVenueBooking.Controllers
{
    public class CustomerEventDetailsController : Controller
    {
        ICustomerEDRepo repository;
        public CustomerEventDetailsController(ICustomerEDRepo repo)
        {
            this.repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.GetAllCustomerEventDetails());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerEventDetails customerEventDetails)
        {
            repository.AddNewCustomerEventDetails(customerEventDetails);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(string name)
        {
            CustomerEventDetails customerEventDetails = repository.GetCustomerEventDetailsById(name);
            if (customerEventDetails != null)
                return View(customerEventDetails);
            else

                return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(CustomerEventDetails customerEventDetails)
        {
            repository.UpdateCustomerEventDetails(customerEventDetails);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(string name)
        {
            CustomerEventDetails customerEventDetails = repository.GetCustomerEventDetailsById(name);
            if (customerEventDetails != null)
                return View(customerEventDetails);
            else

                return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(CustomerEventDetails customerEventDetails)
        {
            repository.DeleteCustomerEventDetails(customerEventDetails.EventName);
            return RedirectToAction("Index");

        }
    }
}
