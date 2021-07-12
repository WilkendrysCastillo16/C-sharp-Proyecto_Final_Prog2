using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Servicios;

namespace Capa_Presentacion.Controllers
{
    public class ServiciosController : Controller
    {
        Servicio_Documentos SD = new Servicio_Documentos();

        
        
        public ActionResult Index()
        {
            return View();
        }

        #region Reportes de Usuarios

        public ActionResult Busqueda_Usuario()
        {
            return View();
        }
        public ActionResult Resultado_Usuario(string Nomb)
        {
            return View(SD.Busca_Usuario(Nomb));
        }
        #endregion

        #region Reportes de Departamentos

        public ActionResult Busqueda_Departamento()
        {
            return View();
        }
        public ActionResult Resultado_Departamento(string Depart)
        {
            return View(SD.Busca_Departamento(Depart));
        }

        #endregion

        #region Reportes de Documentos

        #region Reportes de Todos los Documentos
        public ActionResult Busqueda_All_Documento()
        {
            return View();
        }
        public ActionResult Resultado_All_Documento(int AllDoc)
        {
            return View(SD.Busca_All_Documento(AllDoc));
        }
        #endregion

        #region Reportes For Empleados
        public ActionResult Busqueda_For_Empleado()
        {
            return View();
        }
        public ActionResult Resultado_For_Empleado(int ForEmpl)
        {
            return View(SD.Busca_For_Empleados(ForEmpl));
        }
        #endregion

        #region Reportes Por departamento origen 
        public ActionResult Busqueda_For_Origen_Departamento()
        {
            return View();
        }
        public ActionResult Resultado_For_Origen_Departamento(string ForOrigen)
        {
            return View(SD.Busca_For_Origen_Departamento(ForOrigen));
        }
        #endregion

        #region Reportes Por departamento origen 
        public ActionResult Busqueda_For_Destino_Departamento()
        {
            return View();
        }
        public ActionResult Resultado_For_Departamento_Destino(string ForDestino)
        {
            return View(SD.Busca_For_Destino_Departamento(ForDestino));
        }
        #endregion

        #region Reportes  Por rango de fecha
        public ActionResult Busqueda_For_rango_fecha()
        {
            return View();
        }
        public ActionResult Resultado_For_rango_fecha(string Inicio_Fecha, string Fin_Fecha)
        {
            return View(SD.Busca_For_RANGO_FECHA(Inicio_Fecha, Fin_Fecha));
        }
        #endregion

        #endregion






        //// GET: Servicios/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Servicios/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Servicios/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Servicios/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Servicios/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Servicios/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Servicios/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
