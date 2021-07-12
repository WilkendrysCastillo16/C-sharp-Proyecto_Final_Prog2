using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;


namespace Capa_Presentacion.Controllers
{
    public class DepartamentoController : Controller
    {
        Negocio_Departamento ND = new Negocio_Departamento();

        // GET: Departamento
        public ActionResult Index()
        {
            return View();
        }

        // GET: Departamento/Details/5
        public ActionResult Details()
        {
            return View(ND.Mostrar_Departamento());
        }

        // GET: Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamento/Create
        [HttpPost]
        public ActionResult Create(DEPARTAMENTO DEP)
        {
            ND.Insertar_Departamento(DEP);
                return View();
          
        }

        // GET: Departamento/Edit/5
        public ActionResult Edit(int id)
        {
            return View(ND.GetDepartamento(id));
        }

        // POST: Departamento/Edit/5
        [HttpPost]
        public ActionResult Edit(DEPARTAMENTO DEP)
        {
            ND.Editar_Departamento(DEP);
                return RedirectToAction("Details");
          
            
        }

        // GET: Departamento/Delete/5
        public ActionResult Delete(int? id)
        {
            return View(ND.GetDepartamento(id.Value));
        }

        // POST: Departamento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {

                ND.Eliminar_Departamento(id);
                return RedirectToAction("Details");
            
        }

        public ActionResult GetDepartamento(int id)
        {

            return View (ND.GetDepartamento(id));
        }
    }
}
