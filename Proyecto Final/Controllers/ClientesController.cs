using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_final.Models;

namespace Proyecto_final.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Inmobiliaria(Inmueble inmb)
        {
            ViewBag.Lista = BD.ObtenerTodosInmuebles();
            return View();
        }
        public ActionResult ingresarPropiedad()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuario miUsuario)
        {
            Usuario a = BD.LogIn(miUsuario);
            if (a == null)
            {
                ViewBag.Error = "Usuario y/o contraseña mal ingresado";
                return View("Login");
            }
            else
            {
                Session["idUsuario"] = a.ID;
                Session["nombreUsuario"] = a.NombreDeUsuario;
                Session["Contraseña"] = a.Contraseña;
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public ActionResult ingresarPropiedad(Inmueble inmb, HttpPostedFileBase Image)
        {
           inmb.Imagen = Image.FileName;
           BD.ingresarPropiedad(inmb);
           Image.SaveAs(Server.MapPath("../Img/") + Image.FileName);
           return RedirectToAction("Inmobiliaria");
        }
        public ActionResult Registrarse()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrarse(Usuario a)
        {
            BD.Registro(a);
            return RedirectToAction("Login");
        }
        public ActionResult cerrarSesion()
        {
            Session["nombreUsuario"] = null;
            if (Session["nombreUsuario"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Reservar(int id)
        {

            BD.Reserva(id, Convert.ToInt32(Session["idUsuario"]));
            return RedirectToAction("Inmobiliaria");
        }
    }
}
