using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class Negocio_Documentos
    {
        Datos_Documento DOCUMENT = new Datos_Documento();

        public void InsertarDocuemntos(DOCUMENTO DOC)
        {
            DOCUMENT.Insertar_Documentos(DOC);
        }

        public List<DOCUMENTO> Mostrar_Docuemntos()
        {
            return DOCUMENT.Mostrar_Documentos();
        }

        public void Editar_Documentos(DOCUMENTO DOC)
        {
            DOCUMENT.Editar_Documentos(DOC);
        }
        public void Eliminar_Docuemntos(int id)
        {

            DOCUMENT.Eliminar_Documentos(id);
        }

        public DOCUMENTO GetDocuemntos(int id)
        {
            return DOCUMENT.GetDocumentos(id);
        }

        public List<string> GetForDepartamento()
        {
            return DOCUMENT.GetForDepartamento();
        }

        public List<int> GetForID()
        {
            return DOCUMENT.GetForID();
        }

    }
}
