using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion.Controllers
{
    public class UsuariosController : Controller
    {
        Negocio_Usuarios NU = new Negocio_Usuarios();
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuarios/Details/5
        public ActionResult Details()
        {
            return View(NU.Mostrar_Usuarios());
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            ViewBag.DptSelectList = new SelectList(NU.GetForDepartamento(), "Nombre_Departamento");
            
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(USUARIO US)
        {
          
                ViewBag.DptSelectList = new SelectList(NU.GetForDepartamento(), "Nombre_Departamento");
                NU.Insertar_Usuarios(US);

            return View();
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View(NU.GetUsuarios(id));
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(USUARIO US)
        {
                NU.Editar_Departamentos(US);
                return RedirectToAction("Details");
          
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            return View(NU.GetUsuarios(id.Value));
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
                NU.Eliminar_Usuarios(id);
                return RedirectToAction("Details");
        }
        public ActionResult GetUsuarios(int id)
        {
            return View(NU.GetUsuarios(id));
        }
    }
}
