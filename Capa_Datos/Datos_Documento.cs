using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Datos
{
   public class Datos_Documento
    {
        PROYECTO_FINAL_P2Entities PFP_BD = new PROYECTO_FINAL_P2Entities();

        public void Insertar_Documentos(DOCUMENTO DC)
        {
            PFP_BD.DOCUMENTO.Add(DC);
            PFP_BD.SaveChanges();

            PFP_BD.Codigo_Documentos();
        }

        public List<DOCUMENTO> Mostrar_Documentos()
        {
            return PFP_BD.DOCUMENTO.ToList();
        }

        public void Editar_Documentos(DOCUMENTO DC)
        {
            var DEP = PFP_BD.DOCUMENTO.Find(DC.IdDocumento);
            DEP.Usuario_ID = DC.Usuario_ID;
            DEP.Origen_Departamento = DC.Origen_Departamento;
            DEP.Destino_Departamento = DC.Destino_Departamento;
            DEP.Codigo = DC.Codigo;
            DEP.Fecha = DC.Fecha;

            PFP_BD.SaveChanges();
        }
        public void Eliminar_Documentos(int id)
        {

            var DEP = PFP_BD.DOCUMENTO.Find(id);

            PFP_BD.DOCUMENTO.Remove(DEP);

            PFP_BD.SaveChanges();
        }

        public DOCUMENTO GetDocumentos(int id)
        {
            var Buscar = PFP_BD.DOCUMENTO.Where(N => N.IdDocumento == id).FirstOrDefault();
            return Buscar;
        }

        public List<string> GetForDepartamento()
        {
            var GetDep = PFP_BD.DEPARTAMENTO.ToList();
            var NGetDep = new List<string>();

            foreach (DEPARTAMENTO Dep in GetDep)
            {
                NGetDep.Add(Dep.Nombre_Departamento);
            }

            return NGetDep;
        }

        public List<int> GetForID()
        {
            var USU = PFP_BD.USUARIO.ToList();
            var NUSU = new List<int>();

            foreach (USUARIO usu in USU)
            {
                NUSU.Add(usu.IdUsuario);
            }

            return NUSU;
         
        }
    }
}
