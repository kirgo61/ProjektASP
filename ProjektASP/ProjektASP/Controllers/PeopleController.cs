using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjektASP.Models;

namespace ProjektASP.Controllers
{
    
    public class PeopleController : Controller
    {
        private readonly PersonContext _context;

        public PeopleController(PersonContext context)
        {
            _context = context;
        }


        [AllowAnonymous]
        public async Task<IActionResult> Index(string searchString)
        {
            var persons = from m in _context.Persons select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                persons = persons.Where(s => s.FullName.Contains(searchString));
            }
            return View(await persons.ToListAsync());
        }     
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Persons
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0) return View(new Person());
            else return View(_context.Persons.Find(id));
        }
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("PersonID,FullName,ZipCode,Position,City")] Person person)
        {
            if (ModelState.IsValid)
            {
                if (person.PersonID == 0) { _context.Add(person); }
                else { _context.Update(person); }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        // GET: People/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var person = await _context.Persons.FindAsync(id);
            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

       
    }
}
