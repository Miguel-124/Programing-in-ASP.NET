using BookApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    public class BooksControler : Controller
    {
        // GET: BooksControler
        public ActionResult Index()
        {
            return View();
        }

        // GET: BooksControler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BooksControler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksControler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksControler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BooksControler/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Random
        public IActionResult Random()
        {
            var firstBook = new Book() { Author = "Random Author", Title = "Random Title" };
            return View(firstBook);
        }

        // GET: BooksControler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BooksControler/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
