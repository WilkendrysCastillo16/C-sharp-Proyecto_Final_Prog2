using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class Negocio_Departamento
    {
        Datos_Departamento DD = new Datos_Departamento();

        public void Insertar_Departamento(DEPARTAMENTO DEPART)
        {
            DD.Insertar_Departamentos(DEPART);
        }
        public List<DEPARTAMENTO> Mostrar_Departamento()
        {
            return DD.Mostrar_Departamentos();
        }
        public void Editar_Departamento(DEPARTAMENTO DEPART)
        {
            DD.Editar_Departamentos(DEPART);
        }
        public void Eliminar_Departamento(int id)
        {
            DD.Eliminar_Departamentos(id);
        }
        public DEPARTAMENTO GetDepartamento(int id)
        {

            return DD.GetDepartamentos(id);
        }
      //  <dependentAssembly>
      //  <assemblyIdentity name = "Newtonsoft.Json" culture="neutral" publicKeyToken="30ad4fe6b2a6aeed" />
      //  <bindingRedirect oldVersion = "0.0.0.0-9.0.0.0" newVersion="9.0.0.0" />
      //</dependentAssembly>

  //      <connectionStrings>
  //  <add name = "DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-Capa_Presentacion-20210417025907.mdf;Initial Catalog=aspnet-Capa_Presentacion-20210417025907;Integrated Security=True"
  //    providerName="System.Data.SqlClient" />
  //</connectionStrings>
    }
}
