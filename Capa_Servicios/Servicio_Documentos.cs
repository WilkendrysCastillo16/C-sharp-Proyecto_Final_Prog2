using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Servicios
{
    public class Servicio_Documentos
    {
        PROYECTO_FINAL_P2Entities BD = new PROYECTO_FINAL_P2Entities();

        public List<REPORTE_USUARIOS_Result> Busca_Usuario(string Nombre)
        {
            return BD.REPORTE_USUARIOS(Nombre).ToList();
        }
        public List<REPORTE_DEPARTAMENTOS_Result> Busca_Departamento(string Departamento)
        {
            return BD.REPORTE_DEPARTAMENTOS(Departamento).ToList();
        }

        public List<REPORTE_TODO_LOS_DOCUMENTOS_Result> Busca_All_Documento(int AllDoc)
        {
            return BD.REPORTE_TODO_LOS_DOCUMENTOS(AllDoc).ToList();
        }

        public List<REPORTE_EMPLEADOS_Result> Busca_For_Empleados(int ForEmpl)
        {
            return BD.REPORTE_EMPLEADOS(ForEmpl).ToList();
        }

        public List<REPORTE_ORIGEN_POR_DEPARTAMENTO_Result> Busca_For_Origen_Departamento(string ForOrigen)
        {
            return BD.REPORTE_ORIGEN_POR_DEPARTAMENTO(ForOrigen).ToList();
        }

        public List<REPORTE_DEPARTAMENTO_DESTINO_Result> Busca_For_Destino_Departamento(string ForDestino)
        {
            return BD.REPORTE_DEPARTAMENTO_DESTINO(ForDestino).ToList();
        }

        public List<REPORTE_RANGO_FECHA_Result> Busca_For_RANGO_FECHA(string Inicio_Fecha,string Fin_Fecha)
        {
            return BD.REPORTE_RANGO_FECHA(Inicio_Fecha, Fin_Fecha).ToList();
        }
    }
}
