using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SistemaWebMisRecetas.Data;
using System.Linq;
using SistemaWebMisRecetas.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly RecetasDbContext context;
        public RecetaController(RecetasDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //lista de recetas
            var recetas = context.Recetas.ToList();
            return View(recetas);
        }

        //Create

        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();
            return View("Create", receta);

        }

        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        //Eliminar

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", receta);
            }
        }

        private Receta TraerUna(int id)
        {
            return context.Recetas.Find(id);
        }

        [ActionName("Delete")]
        [HttpPost]

        public ActionResult DeleteConfirmed(int id)
        {
            var receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                context.Recetas.Remove(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]

        public ActionResult Details(int id)
        {
            Receta receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", receta);
            }
        }

        //Editar
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Receta receta = TraerUna(id);
            return View("Edit", receta);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(int id, Receta receta)
        {
            if (id != receta.Id)
            {
                return NotFound();
            }
            else
            {
                context.Entry(receta).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        //Lista por nombre

        [HttpGet]
        public IActionResult TraerAutor(string autor)
        {
            List<Receta> recetas = (from r in context.Recetas
                                        where r.Autor == autor
                                        select r).ToList();
            return View(recetas);
        }

        //Lista por apellido

        [HttpGet]
        public IActionResult TraerApellido(string apellido)
        {
            List<Receta> recetas = (from r in context.Recetas
                                    where r.Apellido == apellido
                                    select r).ToList();
            return View(recetas);
        }
    }
}
