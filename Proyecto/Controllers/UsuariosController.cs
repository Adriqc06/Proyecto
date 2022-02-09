using Microsoft.AspNetCore.Mvc;
using Proyecto.Data;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Controllers
{
    public class UsuariosController :Controller
    {

        private readonly ApplicationDbContext _context;
        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        //http get index
        public IActionResult Index()
        {
            IEnumerable<Usuario> listUsuario = _context.Usuario;
            return View(listUsuario);
        }

        //http get create
        public IActionResult Create()
        {
            return View();
        }

        //http post create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Usuario Usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuario.Add(Usuario);
                _context.SaveChanges();

                TempData["mensaje"] = "El Usuario se ha creado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        //http get edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var usuario = _context.Usuario.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }


        //http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuario.Update(usuario);
                _context.SaveChanges();

                TempData["mensaje"] = "El Usuario se ha modificado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }


        //http get delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var usuario = _context.Usuario.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }



        //http post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUsuario(int? id)
        {
            //obtener usuario desde su id
            var usuario = _context.Usuario.Find(id);

            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuario.Remove(usuario);
            _context.SaveChanges();

            TempData["mensaje"] = "El Usuario se ha eliminado correctamente";
            return RedirectToAction("Index");


        }
    }
}
