using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comercio.Controllers
{
    public class HomeController : Controller
    {
        private Models.TiendaEntities bd = new Models.TiendaEntities();
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar(string id ="")
        {

            var productos = bd.Producto
                .Where(x => x.Descripcion.Contains(id))
                .Take(10)
                .ToList();
            ViewBag.clave = id;
            return View(productos);
        }

        public ActionResult Producto(string id )
        {
            ViewBag.producto = id;
            return View();
        }


    }
}