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
    }
}
