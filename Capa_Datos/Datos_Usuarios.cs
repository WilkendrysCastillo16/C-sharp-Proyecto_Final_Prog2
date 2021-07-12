using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
   public class Datos_Usuarios
    {
        PROYECTO_FINAL_P2Entities PFP_BD = new PROYECTO_FINAL_P2Entities();

        public void Insertar_Usuarios(USUARIO US)
        {
            PFP_BD.USUARIO.Add(US);
            PFP_BD.SaveChanges();
        }

        public List<USUARIO> Mostrar_Usuarios()
        {
            return PFP_BD.USUARIO.ToList();
        }

        public void Editar_Departamentos(USUARIO US)
        {
            var USU = PFP_BD.USUARIO.Find(US.IdUsuario);
            USU.Nombre = US.Nombre;
            USU.Correo = US.Correo;
            USU.Departamento = US.Departamento;
            USU.Cargo = US.Cargo;

            PFP_BD.SaveChanges();
        }
        public void Eliminar_Usuarios(int id)
        {

            var DEP = PFP_BD.USUARIO.Find(id);

            PFP_BD.USUARIO.Remove(DEP);

            PFP_BD.SaveChanges();
        }

        public USUARIO GetUsuarios(int id)
        {
            var Buscar = PFP_BD.USUARIO.Where(m => m.IdUsuario == id).FirstOrDefault();
            return Buscar;
        }

        public List<string> GetForDepartamento()
        {
            var USU = PFP_BD.DEPARTAMENTO.ToList();
            var NUSU = new List<string>();

            foreach (DEPARTAMENTO Dep in USU)
            {
                NUSU.Add(Dep.Nombre_Departamento);
            }

            return NUSU;
        }

    }
}
