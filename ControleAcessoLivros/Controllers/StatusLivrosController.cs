using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleAcessoLivros.Data;
using ControleAcessoLivros.Models;

namespace ControleAcessoLivros.Controllers
{
    public class StatusLivrosController : Controller
    {
        private readonly ControleAcessoLivrosContext _context;

        public StatusLivrosController(ControleAcessoLivrosContext context)
        {
            _context = context;
        }

        // GET: StatusLivros
        public async Task<IActionResult> Index()
        {
            return View(await _context.StatusLivro.ToListAsync());
        }

        // GET: StatusLivros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusLivro = await _context.StatusLivro
                .FirstOrDefaultAsync(m => m.StatusLivroId == id);
            if (statusLivro == null)
            {
                return NotFound();
            }

            return View(statusLivro);
        }

        // GET: StatusLivros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StatusLivros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StatusLivroId,Status")] StatusLivro statusLivro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statusLivro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statusLivro);
        }

        // GET: StatusLivros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusLivro = await _context.StatusLivro.FindAsync(id);
            if (statusLivro == null)
            {
                return NotFound();
            }
            return View(statusLivro);
        }

        // POST: StatusLivros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StatusLivroId,Status")] StatusLivro statusLivro)
        {
            if (id != statusLivro.StatusLivroId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statusLivro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatusLivroExists(statusLivro.StatusLivroId))
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
            return View(statusLivro);
        }

        // GET: StatusLivros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusLivro = await _context.StatusLivro
                .FirstOrDefaultAsync(m => m.StatusLivroId == id);
            if (statusLivro == null)
            {
                return NotFound();
            }

            return View(statusLivro);
        }

        // POST: StatusLivros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var statusLivro = await _context.StatusLivro.FindAsync(id);
            _context.StatusLivro.Remove(statusLivro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatusLivroExists(int id)
        {
            return _context.StatusLivro.Any(e => e.StatusLivroId == id);
        }
    }
}
