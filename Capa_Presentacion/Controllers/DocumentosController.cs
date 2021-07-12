using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Negocio;
using Capa_Entidad;

namespace Capa_Presentacion.Controllers
{
    public class DocumentosController : Controller
    {
        Negocio_Documentos Docum = new Negocio_Documentos();
        // GET: Documentos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Documentos/Details/5
        public ActionResult Details()
        {
            return View(Docum.Mostrar_Docuemntos());
        }

        // GET: Documentos/Create
        public ActionResult Create()
        {
            ViewBag.DptSelectList = new SelectList(Docum.GetForDepartamento(), "Nombre_Departamento");
            ViewBag.UsuSelectList = new SelectList(Docum.GetForID(), "ID_Usuario");

            return View();
        }

        // POST: Documentos/Create
        [HttpPost]
        public ActionResult Create(DOCUMENTO Doc)
        {

            ViewBag.DptSelectList = new SelectList(Docum.GetForDepartamento(), "Nombre_Departamento");
            ViewBag.UsuSelectList = new SelectList(Docum.GetForID(), "ID_Usuario");
            Docum.InsertarDocuemntos(Doc); 
            return View();
            
        }

        // GET: Documentos/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Docum.GetDocuemntos(id));
        }

        // POST: Documentos/Edit/5
        [HttpPost]
        public ActionResult Edit(DOCUMENTO Doc)
        {
            Docum.Editar_Documentos(Doc);
            return RedirectToAction("Details");

        }

        // GET: Documentos/Delete/5
        public ActionResult Delete(int? id)
        {
            return View(Docum.GetDocuemntos(id.Value));
        }

        // POST: Documentos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
                Docum.Eliminar_Docuemntos(id);
                return RedirectToAction("Details");
            
        }
        public ActionResult GetDocumentos(int id)
        {
            return View(Docum.GetDocuemntos(id));
        }
    }
}
