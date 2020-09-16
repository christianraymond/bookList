using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Book.AddAsync(Book); //Add the book to the Queue
                await _db.SaveChangesAsync(); //Now push the change(Book) to the db
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
} 
