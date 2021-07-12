using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class Negocio_Usuarios
    {
        Datos_Usuarios DU = new Datos_Usuarios();

        public void Insertar_Usuarios(USUARIO US)
        {
            DU.Insertar_Usuarios(US);
        }

        public List<USUARIO> Mostrar_Usuarios()
        {
           return DU.Mostrar_Usuarios();
        }

        public void Editar_Departamentos(USUARIO US)
        {
            DU.Editar_Departamentos(US);
        }
        public void Eliminar_Usuarios(int id)
        {

            DU.Eliminar_Usuarios(id);
        }

        public USUARIO GetUsuarios(int id)
        {
            return DU.GetUsuarios(id);
        }

        public List<string> GetForDepartamento()
        {
            return DU.GetForDepartamento();
        }

    }
}
