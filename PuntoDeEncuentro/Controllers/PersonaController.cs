using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PuntoDeEncuentro.Models;

namespace PuntoDeEncuentro.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/
        /// <summary>
        /// agregando el contexto(el manejador de la base de datos)
        /// </summary>
        puntoencuentroEntities db = new puntoencuentroEntities();
        public ActionResult Index()
        {
            
            tbpersona persona = new tbpersona();
            return View();
        }
        [HttpGet]
        public ActionResult Crear() {
            return View();
         }
        /// <summary>
        /// agrega un resgistro a la tabla persona
        /// </summary>
        /// <param name="nuevo">es enviado desde el formulario del cliente</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Crear(tbpersona nuevo)
        {
            //verifica los datos introducidos
            //para trabajar con view
            if (ModelState.IsValid)
            {
                db.tbpersona.Add(nuevo);
                if (db.SaveChanges() > 0) {
                    Redirect("index");
                }
            }
            //mandamos el modelo para que el usuario 
            //verifique los errores
            return View(nuevo);
        }

    }
}
