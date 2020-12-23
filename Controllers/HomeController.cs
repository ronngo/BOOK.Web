using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BOOK.Web1.Models;

namespace BOOK.Web1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Book> manufactories = new List<Book>();
            manufactories = Helper.ApiHelper<List<Book>>.HttpGetAsync("api/Book/gets");
            return View(manufactories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateBook model)
        {
            if (ModelState.IsValid)
            {
                var result = new CreateBookResult();
                result = Helper.ApiHelper<CreateBookResult>.HttpPostAsync("api/Book/create", "POST", model);
                if (result.BookId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }



        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(UpdateBook model)
        {
            if (ModelState.IsValid)
            {
                var result = new UpdateBookResult();
                result = Helper.ApiHelper<UpdateBookResult>.HttpPostAsync("api/Book/update", "POST", model);
                if (result.BookId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(DeleteBook model)
        {
            if (ModelState.IsValid)
            {
                var result = new DeleteBookResult();
                result = Helper.ApiHelper<DeleteBookResult>.HttpPostAsync("api/Book/Delete", "POST", model);
                if (result.BookId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }
    }
}
