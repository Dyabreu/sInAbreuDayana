using System;
using Microsoft.AspNetCore.Mvc;

namespace SistemaWebMisRecetas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido a nuestra Web de Recetas";
            ViewBag.Fecha = "Hoy es:" + DateTime.Now.ToString();
            return View();
        }

    }

}