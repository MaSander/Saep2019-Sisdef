using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sisdef.Web.Razor.Domains;

namespace Sisdef.Web.Razor.Controllers
{
    public class RegistroDefeitosController : Controller
    {
        private readonly SisdefContext _context;

        public RegistroDefeitosController(SisdefContext context)
        {
            _context = context;
        }

        // GET: RegistroDefeitos
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            var sisdefContext = _context.RegistroDefeito.Include(r => r.Defeito).Include(r => r.Equipamento.TipoEquipamento);
            return View(await sisdefContext.ToListAsync());
        }

        // GET: RegistroDefeitos/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            ViewData["DefeitoId"] = new SelectList(_context.Defeito, "Id", "Nome");
            ViewData["EquipamentoId"] = new SelectList(_context.Equipamento.Include(x => x.TipoEquipamento), "Id", "TipoEquipamento.Nome");
            return View();
        }

        // POST: RegistroDefeitos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataProblema,EquipamentoId,DefeitoId,HoraInicio,HoraFinal")] RegistroDefeito registroDefeito)
        {
            if (registroDefeito.DataProblema > DateTime.Now)
            {
                ViewBag.Mensagem = "ERRO: A data esta maior do que a atual";
                return View(registroDefeito);

            }

            if (registroDefeito.HoraInicio > registroDefeito.HoraFinal)
            {
                ViewBag.Mensagem = "ERRO: Hora inicial maior que a Final";
                return View(registroDefeito);
            }

            if (ModelState.IsValid)
            {
                _context.Add(registroDefeito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            ViewData["DefeitoId"] = new SelectList(_context.Defeito, "Id", "Nome", registroDefeito.DefeitoId);
            ViewData["EquipamentoId"] = new SelectList(_context.Equipamento, "Id", "Id", registroDefeito.EquipamentoId);
            return View(registroDefeito);
        }

    }
}
