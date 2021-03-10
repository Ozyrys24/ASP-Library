using Biblioteka.Data;
using Biblioteka.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka.Controllers
{
    //[Authorize]
    public class BooksController : Controller
    {
        private readonly LibraryDBContext _db;

        public BooksController(LibraryDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<BooksModel> model = _db.BooksModel;
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BooksModel booksModel)
        {
            _db.BooksModel.Add(booksModel);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var book = _db.BooksModel.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(BooksModel booksModel)
        {
            _db.BooksModel.Update(booksModel);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var book = _db.BooksModel.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        public IActionResult Delete(BooksModel booksModel)
        {
            _db.BooksModel.Remove(booksModel);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var book = _db.BooksModel.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
    }
}
