using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PuntoDeEncuentro.Controllers
{
    public class borrarController : Controller
    {
        //
        // GET: /borrar/

        public ActionResult Index()
        {
            //PuntoDeEncuentro.Models.puntoencuentroEntities bd = new Models.puntoencuentroEntities();
            //PuntoDeEncuentro.Models.tbevento n = new Models.tbevento();
            //n.estado = 1;
            //n.titulo = "-";
            //bd.tbevento.Add(n);

            //try {
            //    if (bd.SaveChanges() == 1)
            //    {
            //        //correcto
            //    }
            //    else
            //    {
            //        //errores en informacion
            //    }
            //}
            //catch { 
            
            //}
            //return View();

            ///
            PuntoDeEncuentro.Models.puntoencuentroEntities bd = new Models.puntoencuentroEntities();
            PuntoDeEncuentro.Models.tbpersona n = new Models.tbpersona();
            n.nombre = "david";
            n.paterno = "beltran";
            n.materno = "cabrera";
            n.ci = "8546252";
            n.fechanac = DateTime.Now;
            n.fechacreacion = DateTime.Now;
            n.fechamodificacion = DateTime.Now;
            n.estado = 111;
            bd.tbpersona.Add(n);

            try
            {
                if (bd.SaveChanges() == 1)
                {
                    //correcto
                }
                else
                {
                    //errores en informacion
                }
            }
            catch
            {

            }
            return View();
        }

    }
}
