using CodeFirstVenueBooking.Models;
using CodeFirstVenueBooking.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstVenueBooking.Controllers
{
    public class DecorationController : Controller
    {
        IDecorationRepo repository;
        public DecorationController(IDecorationRepo repo)
        {
            this.repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository.GetAllDecorations());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Decoration decoration)
        {
            repository.AddNewDecoration(decoration);
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            Decoration decoration = repository.GetDecorationById(id);
            if(decoration!=null)
                return View(decoration);
            else

                return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Decoration decoration)
        {
            repository.UpdateDecoration(decoration);
            return RedirectToAction("Index");

        }

        

        public IActionResult Delete(int id)
        {
            Decoration decoration = repository.GetDecorationById(id);
            if (decoration != null)
                return View(decoration);
            else

                return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Decoration decoration)
        {
            repository.DeleteDecoration(decoration.Id);
            return RedirectToAction("Index");

        }
    }
}