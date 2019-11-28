using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_final.Models;

namespace Proyecto_Final.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.tipos = BD.ObtenerTodosLosTipos();
            ViewBag.barrios = BD.ObtenerTodosLosBarrios();
            return View();
        }
        [HttpPost]
        public ActionResult Index(BusquedaXD busqueda)
        {
            BD.ObtenerTodosInmuebles();
            return RedirectToAction("Inmobiliaria", "Clientes");
        }
    }
}