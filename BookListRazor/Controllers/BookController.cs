using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;

namespace BookListRazor.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : Controller
    {

        private readonly ApplicationDbContext _db;
        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _db.Book.ToList() });
        }
    }
}
