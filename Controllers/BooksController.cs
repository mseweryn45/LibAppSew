using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibAppSew.Models;

namespace LibAppSew.Controllers
{
    public class BooksController : Controller
    {
        //będzie pokazywała randomową książkę 

        public IActionResult Random()
        {
            var firstBook = new Book() { Name = "English dictionary" };
            return View(firstBook);
        }

        public IActionResult Edit(int bookId)
        {
            return Content("id=" + bookId);
        }
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }
    }
}
