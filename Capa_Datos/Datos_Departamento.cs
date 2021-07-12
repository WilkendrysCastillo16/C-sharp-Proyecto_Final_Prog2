using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
   public class Datos_Departamento
    {
        PROYECTO_FINAL_P2Entities PFP_BD = new PROYECTO_FINAL_P2Entities();
        public void Insertar_Departamentos(DEPARTAMENTO DP)
        {
            PFP_BD.DEPARTAMENTO.Add(DP);
            PFP_BD.SaveChanges();
        }

        public List<DEPARTAMENTO> Mostrar_Departamentos()
        {
            return PFP_BD.DEPARTAMENTO.ToList();
        }

        public void Editar_Departamentos(DEPARTAMENTO DP)
        {
            var DEP = PFP_BD.DEPARTAMENTO.Find(DP.IdDepartamento);
            DEP.Nombre_Departamento = DP.Nombre_Departamento;
            DEP.Siglas = DP.Siglas;

            PFP_BD.SaveChanges();
        }
        public void Eliminar_Departamentos(int id)
        {

            var DEP = PFP_BD.DEPARTAMENTO.Find(id);

            PFP_BD.DEPARTAMENTO.Remove(DEP);

            PFP_BD.SaveChanges();
        }

        public DEPARTAMENTO GetDepartamentos(int id)
        {
            var Buscar = PFP_BD.DEPARTAMENTO.Where(N => N.IdDepartamento == id).FirstOrDefault();
            return Buscar;
        }

    }
}
