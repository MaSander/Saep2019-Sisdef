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
    public class LoginController : Controller
    {
        private readonly SisdefContext _context;

        public LoginController(SisdefContext context)
        {
            _context = context;
        }

        // GET: Login/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                Usuario retorno = _context.Usuario.FirstOrDefault(x => x.Email == usuario.Email && x.Senha == usuario.Senha);

                if (retorno == null)
                {
                    ViewBag.Mensagem = "ERRO: usuárion e/ou senha incorretos";
                    return View(usuario);
                }

                HttpContext.Session.SetString("email", usuario.Email);
                return RedirectToAction("Create", "RegistroDefeitos");
            }
            return View(usuario);
        }
    }
}
