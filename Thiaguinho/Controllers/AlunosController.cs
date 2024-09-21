using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Thiaguinho.Data;
using Thiaguinho.Models;

namespace Thiaguinho.Controllers
{
    public class AlunosController : Controller
    {
        private readonly ConnectionContext _context;

        public AlunosController(ConnectionContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Alunos.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,DataNascimento")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }
    }
}
