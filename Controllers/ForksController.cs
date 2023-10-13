using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gurdeep_Fork_Assignment.Data;
using Gurdeep_Fork_Assignment.Models;

namespace Gurdeep_Fork_Assignment.Controllers
{
    public class ForksController : Controller
    {
        private readonly ForkContext _context;

        public ForksController(ForkContext context)
        {
            _context = context;
        }

        // GET: Forks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fork = await _context.Fork
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fork == null)
            {
                return NotFound();
            }

            return View(fork);
        }

        // GET: Forks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Forks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Model,PurchaseDate,Price,HandleMaterial,TineCount,Rating")] Fork fork)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fork);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fork);
        }

        // GET: Forks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fork = await _context.Fork.FindAsync(id);
            if (fork == null)
            {
                return NotFound();
            }
            return View(fork);
        }

        // POST: Forks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Model,PurchaseDate,Price,HandleMaterial,TineCount,Rating")] Fork fork)
        {
            if (id != fork.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fork);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ForkExists(fork.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(fork);
        }

        // GET: Forks
        public async Task<IActionResult> Index(string searchString, string forkModel)
        {
            var forks = from f in _context.Fork
                        select f;

            // Use LINQ to get a list of brands.
            IQueryable<string> brandQuery = from f in _context.Fork
                                            orderby f.Model
                                          select f.Model;

            if (!String.IsNullOrEmpty(searchString))
            {
                forks = forks.Where(f => f.Brand.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(forkModel))
            {
                forks = forks.Where(f => f.Model == forkModel);
            }

            var forkModelVM = new ForkModelViewModel
            {
                Forks = await forks.ToListAsync(),
                Models = new SelectList(await brandQuery.Distinct().ToListAsync()),
             };

            return View(forkModelVM);
        }

        // GET: Forks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fork = await _context.Fork
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fork == null)
            {
                return NotFound();
            }

            return View(fork);
        }

        // POST: Forks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fork = await _context.Fork.FindAsync(id);
            _context.Fork.Remove(fork);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ForkExists(int id)
        {
            return _context.Fork.Any(e => e.Id == id);
        }
    }
}
