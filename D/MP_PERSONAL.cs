using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class MP_PERSONAL
    {
        private Accesso accesso = new Accesso();


        public List<Business.PERSONAL> Listar()
        {
            DataTable tabla = accesso.Leer("ListarPersonal", null);

            List<Business.PERSONAL> personas = new List<Business.PERSONAL>();
            foreach (DataRow registro in tabla.Rows)
            {
                Business.PERSONAL persona = new Business.PERSONAL();

                persona.IdPersonal = int.Parse(registro["IdPersonal"].ToString());
                persona.ApPaterno = registro["ApPaterno"].ToString();
                persona.ApMaterno = registro["ApMaterno"].ToString();
                persona.Nombre1 = registro["Nombre1"].ToString();
                persona.Nombre2 = registro["Nombre2"].ToString();
                persona.NombreCompleto = registro["NombreCompleto"].ToString();
                persona.FchNac = registro["FchNac"].ToString();
                persona.FchIngreso = registro["FchIngreso"].ToString();

                personas.Add(persona);
            }
            return personas;

        }


        public List<Business.PERSONAL> VerPersonal(int IdPersonal)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(accesso.CrearParametro("@IdPersonal", IdPersonal));

            DataTable tabla = accesso.Leer("VerPersonal", parameters);

            List<Business.PERSONAL> personas = new List<Business.PERSONAL>();
            foreach (DataRow registro in tabla.Rows)
            {
                Business.PERSONAL persona = new Business.PERSONAL();

                persona.IdPersonal = int.Parse(registro["IdPersonal"].ToString());
                persona.ApPaterno = registro["ApPaterno"].ToString();
                persona.ApMaterno = registro["ApMaterno"].ToString();
                persona.Nombre1 = registro["Nombre1"].ToString();
                persona.Nombre2 = registro["Nombre2"].ToString();
                persona.NombreCompleto = registro["NombreCompleto"].ToString();
                persona.FchNac = registro["FchNac"].ToString();
                persona.FchIngreso = registro["FchIngreso"].ToString();

                personas.Add(persona);
            }
            return personas;

        }



        public int Agregar(Business.PERSONAL persona)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(accesso.CrearParametro("@IdPersonal", persona.IdPersonal));
            parameters.Add(accesso.CrearParametro("@ApPaterno", persona.ApPaterno));
            parameters.Add(accesso.CrearParametro("@ApMaterno", persona.ApMaterno));
            parameters.Add(accesso.CrearParametro("@Nombre1", persona.Nombre1));
            parameters.Add(accesso.CrearParametro("@Nombre2", persona.Nombre2));
            parameters.Add(accesso.CrearParametro("@FchNac", persona.FchNac));
            parameters.Add(accesso.CrearParametro("@FchIngreso", persona.FchIngreso));

            return accesso.Escribir("InsertarPersonal", parameters);

        }
        public int Modificar(Business.PERSONAL persona)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(accesso.CrearParametro("@IdPersonal", persona.IdPersonal));
            parameters.Add(accesso.CrearParametro("@ApPaterno", persona.ApPaterno));
            parameters.Add(accesso.CrearParametro("@ApMaterno", persona.ApMaterno));
            parameters.Add(accesso.CrearParametro("@Nombre1", persona.Nombre1));
            parameters.Add(accesso.CrearParametro("@Nombre2", persona.Nombre2));
            parameters.Add(accesso.CrearParametro("@FchNac", persona.FchNac));
            parameters.Add(accesso.CrearParametro("@FchIngreso", persona.FchIngreso));

            return accesso.Escribir("ActualizarPersonal", parameters);

        }
        public int Eliminar(int idPersonal)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(accesso.CrearParametro("@IdPersonal", idPersonal));

            return accesso.Escribir("EliminarPersonal", parameters);
        }
    }
}
